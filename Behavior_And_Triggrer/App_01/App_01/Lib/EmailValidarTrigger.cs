using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App_01.Lib
{
    public class EmailValidarTrigger : TriggerAction<Entry>
    {
        protected override void Invoke(Entry sender)
        {
            if (sender.Text.IndexOf("@") <= 0)
            {
                sender.TextColor = Color.Red;
            }
            else
            {
                sender.TextColor = Color.Blue;
            }

        }
    }
}
