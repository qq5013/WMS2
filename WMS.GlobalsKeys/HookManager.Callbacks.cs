using System;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace WMS.GlobalsKeys
{
  public static partial class HookManager
  {
    /// <summary>
    /// ������� ����������� ������� �������������� ��������������� ���������
    /// </remarks>
    private delegate int HookProc(int nCode, int wParam, IntPtr lParam);

    #region Keyboard hook processing
    /// <summary>
    /// ������ �� �������-���������� ������������� �������
    /// ��������� ������ ��� �������� ������
    /// When passing delegates to unmanaged code, they must be kept alive by the managed application 
    /// until it is guaranteed that they will never be called.
    /// </summary>
    private static HookProc s_KeyboardDelegate;
    /// <summary>
    /// ��������� �� ������������� ���
    /// </summary>
    private static int s_KeyboardHookHandle;
    /// <summary>
    /// ������� ��������� ������������� �������� �� ����������
    /// </summary>
    private static int KeyboardHookProc(int nCode, Int32 wParam, IntPtr lParam)
    {
      if (nCode >= 0)
      {
        int vkCode = Marshal.ReadInt32(lParam);
        Task.Factory.StartNew((code) =>
        {
          Keys keyPressed = (Keys)code;
          KeyEventArgs e = new KeyEventArgs(keyPressed);
          //raise KeyDown
          if (changeKeyState != null && (wParam == WM_KEYDOWN || wParam == WM_SYSKEYDOWN))
          {
            lock (KeyCollectionLocker)
            {
              if (!currentDownedKeys.Contains((Keys)e.KeyCode))
              {
                currentDownedKeys.Add((Keys)e.KeyCode);
                RebuildDownedDescription();
              }
            }
            changeKeyState.Invoke();
          }
          // raise KeyUp
          if (changeKeyState != null && (wParam == WM_KEYUP || wParam == WM_SYSKEYUP))
          {
            lock (KeyCollectionLocker)
            {
              if (currentDownedKeys.Contains((Keys)e.KeyCode))
              {
                currentDownedKeys.Remove((Keys)e.KeyCode);
                RebuildDownedDescription();
              }
            }
            changeKeyState.Invoke();
          }
        }, vkCode);
      }
      //forward to other application
      return CallNextHookEx(s_KeyboardHookHandle, nCode, wParam, lParam);
    }
    /// <summary>
    /// ��������� ����������� ��������� ������������ ���������
    /// </summary>
    private static void EnsureSubscribedToGlobalKeyboardEvents()
    {
      // install Keyboard hook only if it is not installed and must be installed
      if (s_KeyboardHookHandle == 0)
      {
        //See comment of this field. To avoid GC to clean it up.
        s_KeyboardDelegate = KeyboardHookProc;
        //install hook
        using (Process curProcess = Process.GetCurrentProcess())
        {
          using (ProcessModule curModule = curProcess.MainModule)
          {
            s_KeyboardHookHandle = SetWindowsHookEx(WH_KEYBOARD_LL, s_KeyboardDelegate, GetModuleHandle(curModule.ModuleName), 0);
          }
        }
        //If SetWindowsHookEx fails.
        if (s_KeyboardHookHandle == 0)
        {
          throw new Exception("���������� ��� ��������� ������������ ����������. ��� ������: " + Marshal.GetLastWin32Error().ToString());
        }
      }
    }
    /// <summary>
    /// ������� �������� ����������� ������������ ������� ����������
    /// </summary>
    private static void TryUnsubscribeFromGlobalKeyboardEvents()
    {
      //if no subsribers are registered unsubsribe from hook
      if (changeKeyState != null)
      {
        ForceUnsunscribeFromGlobalKeyboardEvents();
      }
    }
    /// <summary>
    /// �������� ����������� ������������ ������� ����������
    /// </summary>
    private static void ForceUnsunscribeFromGlobalKeyboardEvents()
    {
      if (s_KeyboardHookHandle != 0)
      {
        //uninstall hook
        int result = UnhookWindowsHookEx(s_KeyboardHookHandle);
        //reset invalid handle
        s_KeyboardHookHandle = 0;
        //Free up for GC
        s_KeyboardDelegate = null;
        if (result == 0)
        {
          throw new Exception("�� ������� ��������� ������������ ����������. ��� ������: " + Marshal.GetLastWin32Error().ToString());
        }
      }
    }
    #endregion
  }
}
