using System.Collections.Generic;
using System.Windows.Forms;
using System.Text;
using System;

namespace WMS.GlobalsKeys
{
  /// <summary>
  /// Делегат для события по нажатии горячих клавиш
  /// </summary>
  public delegate void HotKeyEventHandler();
  /// <summary>
  /// Комбинация горячих клавиш
  /// </summary>
  public class HotKeyCombination : List<Keys>, IDisposable
  {
    #region Ctors
    public HotKeyCombination() { }

    public HotKeyCombination(HotKeyEventHandler handler)
    {
      Pressed += handler;
    }

    public HotKeyCombination(Keys[] keys, HotKeyEventHandler handler)
    {
      Pressed += handler;
      AddRange(keys);
    }

    public HotKeyCombination(Keys[] keys)
    {
      AddRange(keys);
    }
    #endregion

    #region Fields
    /// <summary>
    /// Указывает что комбинация не содержит ни одной клавиши
    /// </summary>
    public bool IsEmpty
    {
      get
      {
        return Count == 0;
      }
    }
    /// <summary>
    /// Сигнал о нажатии заданной комбинации
    /// </summary>
    public event HotKeyEventHandler Pressed;
    #endregion

    #region Methods
    /// <summary>
    /// Проверка на нажатие нужной комбинации клавиш
    /// </summary>
    /// <param name="checkingKeys"></param>
    public bool Check()
    {
      List<Keys> checkingKeys = HookManager.CurrentDownedKeys;
      int count = 0;
      for (int i = 0; i < checkingKeys.Count; i++)
      {
        for (int j = 0; j < Count; j++)
        {
          if (checkingKeys[i] == this[j])
            count++;
        }
      }
      // Если в запомненной комбинации и переданной одинаковое количество клавиш, и они совпадают, оповещает о нажатии комбинации
      if (count == Count && count == checkingKeys.Count && Pressed != null)
      {
        Pressed();
        return true;
      }
      return false;
    }
    /// <summary>
    /// Получение клавиш в комбинации в виде строки вида Key1+Key2+...+Keyn
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      foreach (Keys _key in this)
      {
        sb.Append(_key.ToString() + " + ");
      }
      return sb.ToString().TrimEnd('+', ' ');
    }
    #endregion

    public void Dispose()
    {
      this.Clear();
    }
  }
}
