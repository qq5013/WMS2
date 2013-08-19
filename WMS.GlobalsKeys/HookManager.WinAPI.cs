using System;
using System.Runtime.InteropServices;

namespace WMS.GlobalsKeys
{
  public static partial class HookManager
  {
    #region Windows constants
    //values from Winuser.h in Microsoft SDK.
    /// <summary>
    /// Windows NT/2000/XP: Installs a hook procedure that monitors low-level keyboard  input events.
    /// </summary>
    private const int WH_KEYBOARD_LL = 13;
    /// <summary>
    /// Installs a hook procedure that monitors keystroke messages. For more information, see the KeyboardProc hook procedure. 
    /// </summary>
    private const int WH_KEYBOARD = 2;
    /// <summary>
    /// The WM_KEYDOWN message is posted to the window with the keyboard focus when a nonsystem 
    /// key is pressed. A nonsystem key is a key that is pressed when the ALT key is not pressed.
    /// </summary>
    private const int WM_KEYDOWN = 0x100;
    /// <summary>
    /// The WM_KEYUP message is posted to the window with the keyboard focus when a nonsystem 
    /// key is released. A nonsystem key is a key that is pressed when the ALT key is not pressed, 
    /// or a keyboard key that is pressed when a window has the keyboard focus.
    /// </summary>
    private const int WM_KEYUP = 0x101;
    /// <summary>
    /// The WM_SYSKEYDOWN message is posted to the window with the keyboard focus when the user 
    /// presses the F10 key (which activates the menu bar) or holds down the ALT key and then 
    /// presses another key. It also occurs when no window currently has the keyboard focus; 
    /// in this case, the WM_SYSKEYDOWN message is sent to the active window. The window that 
    /// receives the message can distinguish between these two contexts by checking the context 
    /// code in the lParam parameter. 
    /// </summary>
    private const int WM_SYSKEYDOWN = 0x104;
    /// <summary>
    /// The WM_SYSKEYUP message is posted to the window with the keyboard focus when the user 
    /// releases a key that was pressed while the ALT key was held down. It also occurs when no 
    /// window currently has the keyboard focus; in this case, the WM_SYSKEYUP message is sent 
    /// to the active window. The window that receives the message can distinguish between 
    /// these two contexts by checking the context code in the lParam parameter. 
    /// </summary>
    private const int WM_SYSKEYUP = 0x105;
    private const byte VK_SHIFT = 0x10;
    private const byte VK_CAPITAL = 0x14;
    private const byte VK_NUMLOCK = 0x90;
    #endregion

    #region Windows function imports
    /// <summary>
    /// Возвращает дескриптор модуля указанного типа
    /// </summary>
    /// <param name="lpModuleName"></param>
    /// <returns></returns>
    [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
    public static extern IntPtr GetModuleHandle(string lpModuleName);
    /// <summary>
    /// Функция передающая перехватываемое сообщение следующему обработчику
    /// </summary>
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
    private static extern int CallNextHookEx(int idHook, int nCode, int wParam, IntPtr lParam);
    /// <summary>
    /// Функция устанавливает перехват системных сигналов
    /// </summary>
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
    private static extern int SetWindowsHookEx(int idHook, HookProc lpfn, IntPtr hMod, int dwThreadId);
    /// <summary>
    /// Отключение перехвата системных сигналов
    /// </summary>
    [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall, SetLastError = true)]
    private static extern int UnhookWindowsHookEx(int idHook);
    #endregion
  }
}