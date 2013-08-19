using System.Windows.Forms;
using System.Text;
using System.Collections.Generic;
using System;

namespace WMS.GlobalsKeys
{
  public delegate void HookManagerEventHandler();
  /// <summary>
  /// Перехватывает нажатия клавиш клавиатуры
  /// </summary>
  public static partial class HookManager
  {
    #region Private fields
    /// <summary>
    /// Количество подписчиков
    /// </summary>
    private static int count_subsribtors = 0;
    /// <summary>
    /// Количество подписчиков, до текущего изменения коллекции подписчиков
    /// </summary>
    private static int last_count_subsribtors = 0;
    /// <summary>
    /// Локер коллекции подписчиков
    /// </summary>
    private static readonly object subs_locker = new object();
    /// <summary>
    /// Событие на изменение состояния нажатых клавиш
    /// </summary>
    private static event HookManagerEventHandler changeKeyState;
    #endregion
    /// <summary>
    /// Событие на изменение состояния нажатых клавиш
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

    #region Список нажатых клавиш
    #region Private
    /// <summary>
    /// Локер коллекции нажатых клавиш
    /// </summary>
    private static readonly object KeyCollectionLocker = new object();
    /// <summary>
    /// Текущий список нажатых клавиш
    /// </summary>
    private static List<Keys> currentDownedKeys = new List<Keys>();
    /// <summary>
    /// Текущие нажатые клавиши в виде строки
    /// </summary>
    private static string CurrentDownedKeysString = String.Empty;
    #endregion

    /// <summary>
    /// Создает описание нажатой комбинации клавиш
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
    /// Список текущих нажатых клавиш
    /// </summary>
    public static List<Keys> CurrentDownedKeys
    {
      get { return currentDownedKeys; }
    }
    /// <summary>
    /// Текущие нажатые клавиши в виде строки
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
    /// Проверка количества подписчиков, и отключение/включение перехвата сигналов
    /// в зависимости от их наличия
    /// </summary>
    private static void CheckSubscribtors()
    {
      // Если появиля подписчик и до него не было других
      if (count_subsribtors == 1 && last_count_subsribtors == 0)
      {
        // Включаем перехват
        EnsureSubscribedToGlobalKeyboardEvents();
      }
      // Если не осталось подписчиков, и до этого был один
      else if (count_subsribtors == 0 && last_count_subsribtors == 1)
      {
        // Отключаем перехват
        TryUnsubscribeFromGlobalKeyboardEvents();
      }
      last_count_subsribtors = count_subsribtors;
    }
    /// <summary>
    /// Добавление подписчика
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
    /// Удаление подписчика
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
