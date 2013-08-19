using System.Collections.Generic;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WMS.GlobalsKeys
{
  public delegate void HotKeyManagerEventHandler(string current);

  /// <summary>
  /// Класс содержит коллекцию комбинаций клавиш, и отслеживает проверку нажатия комбинаций
  /// </summary>
  public class HotKeysManager : Dictionary<string, HotKeyCombination>, IDisposable
  {
    #region Ctor
    public HotKeysManager()
    {
      EnableHotKeys();
    }
    #endregion

    #region Fields
    /// <summary>
    /// Локер коллекции комбинаций
    /// </summary>
    private readonly object HotKeyCollectionLocker = new object();
    #endregion

    #region Events
    /// <summary>
    /// Оповещает о добавлении новой комбинации
    /// </summary>
    public event HotKeyManagerEventHandler NewCombination;
    #endregion

    #region Private methods
    /// <summary>
    /// Проверка комбинаций
    /// </summary>
    void HookManager_ChangeKeyState()
    {
        Parallel.ForEach(Keys, (_key) => this[_key].Check());


    }

      #endregion

    #region Export methods
    /// <summary>
    /// Добавление комбинации
    /// </summary>
    /// <param name="description">Описание</param>
    /// <param name="combination">Комбинация клавиш</param>
    public void AddHotKey(string description, HotKeyCombination combination)
    {
      if (!ContainsKey(description) && !combination.IsEmpty)
      {
        Add(description, combination);
        if (NewCombination != null)
          NewCombination(combination.ToString());
      }
    }
    /// <summary>
    /// Добавление комбинации, в качестве ключа будет использовано описание клавиш комбинации
    /// </summary>
    /// <param name="combination"></param>
    public void AddHotKey(HotKeyCombination combination)
    {
      AddHotKey(combination.ToString(), combination);
    }
    /// <summary>
    /// Удаление комбинации по ключу
    /// </summary>
    /// <param name="key">Ключ комбинации в коллекции</param>
    public void RemoveHotKey(string key)
    {
      if (ContainsKey(key))
        Remove(key);
    }
    /// <summary>
    /// Попытка удаления комбинации, в качетве ключа берется описание комбинации
    /// </summary>
    /// <param name="combination">Комбинация которую нужно удалить из коллекции</param>
    public void RemoveHotKey(HotKeyCombination combination)
    {
      Remove(combination.ToString());
    }
    /// <summary>
    /// Включение перехвата
    /// </summary>
    public void EnableHotKeys()
    {
      HookManager.ChangeKeyState += HookManager_ChangeKeyState;
    }
    /// <summary>
    /// Отключение перехвата
    /// </summary>
    public void DisableHotKeys()
    {
      HookManager.ChangeKeyState -= HookManager_ChangeKeyState;
    }
    #endregion

    public void Dispose()
    {
      foreach (string key in this.Keys)
        this[key].Dispose();
      this.Clear();
      GC.SuppressFinalize(this);
    }
  }
}
