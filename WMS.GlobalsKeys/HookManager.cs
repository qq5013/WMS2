using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using System;

namespace WMS.GlobalsKeys
{
  public delegate void HookManagerEventHandler();
  /// <summary>
  /// ������������� ������� ������ ����������
  /// </summary>
  public static partial class HookManager
  {
    #region Private fields
    /// <summary>
    /// ���������� �����������
    /// </summary>
    private static int count_subsribtors = 0;
    /// <summary>
    /// ���������� �����������, �� �������� ��������� ��������� �����������
    /// </summary>
    private static int last_count_subsribtors = 0;
    /// <summary>
    /// ����� ��������� �����������
    /// </summary>
    private static readonly object subs_locker = new object();
    /// <summary>
    /// ������� �� ��������� ��������� ������� ������
    /// </summary>
    private static event HookManagerEventHandler changeKeyState;
    #endregion
    /// <summary>
    /// ������� �� ��������� ��������� ������� ������
    /// </summary>
    public static event HookManagerEventHandler ChangeKeyState
    {
      add
      {
        Inc();
        changeKeyState += value;
      }
      remove
      {
        changeKeyState -= value;
        Dec();
      }
    }

    #region ������ ������� ������
    #region Private
    /// <summary>
    /// ����� ��������� ������� ������
    /// </summary>
    private static readonly object KeyCollectionLocker = new object();
    /// <summary>
    /// ������� ������ ������� ������
    /// </summary>
    private static List<Keys> currentDownedKeys = new List<Keys>();
    /// <summary>
    /// ������� ������� ������� � ���� ������
    /// </summary>
    private static string CurrentDownedKeysString = String.Empty;
    #endregion

    /// <summary>
    /// ������� �������� ������� ���������� ������
    /// </summary>
    private static void RebuildDownedDescription()
    {
      StringBuilder sb = new StringBuilder();
      foreach (Keys _key in currentDownedKeys)
      {
        sb.Append(_key.ToString() + " + ");
      }
      CurrentDownedKeysString = sb.ToString().TrimEnd('+', ' ');
    }

    #region Public method
    /// <summary>
    /// ������ ������� ������� ������
    /// </summary>
    public static List<Keys> CurrentDownedKeys
    {
      get { return currentDownedKeys; }
    }
    /// <summary>
    /// ������� ������� ������� � ���� ������
    /// </summary>
    public static string CurrentDownedKeysDescription
    {
      get
      {
        return CurrentDownedKeysString;
      }
    }
    #endregion
    #endregion

    #region Methods
    /// <summary>
    /// �������� ���������� �����������, � ����������/��������� ��������� ��������
    /// � ����������� �� �� �������
    /// </summary>
    private static void CheckSubscribtors()
    {
      // ���� ������� ��������� � �� ���� �� ���� ������
      if (count_subsribtors == 1 && last_count_subsribtors == 0)
      {
        // �������� ��������
        EnsureSubscribedToGlobalKeyboardEvents();
      }
      // ���� �� �������� �����������, � �� ����� ��� ����
      else if (count_subsribtors == 0 && last_count_subsribtors == 1)
      {
        // ��������� ��������
        TryUnsubscribeFromGlobalKeyboardEvents();
      }
      last_count_subsribtors = count_subsribtors;
    }
    /// <summary>
    /// ���������� ����������
    /// </summary>
    private static void Inc()
    {
      lock (subs_locker)
      {
        count_subsribtors++;
        CheckSubscribtors();
      }
    }
    /// <summary>
    /// �������� ����������
    /// </summary>
    private static void Dec()
    {
      lock (subs_locker)
      {
        count_subsribtors--;
        CheckSubscribtors();
      }
    }
    #endregion
  }
}
