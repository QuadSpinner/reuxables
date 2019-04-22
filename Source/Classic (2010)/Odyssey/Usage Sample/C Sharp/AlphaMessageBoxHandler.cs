using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Odyssey
{
    public class AlphaMessageBoxHandler
    {

        public MessageBoxButton MessageBoxStyle { get; set; }
        public MessageBoxResult MessageResult { get; set; }

        public MessageBoxResult Show(string MessageText, string MessageTitle, MessageBoxButton DialogStyle) 
        {
            AlphaMessageBox f = new AlphaMessageBox();
            
            f.alphaMessageBoxStyle = DialogStyle;
            f.Title = MessageTitle;
            f.textPrompt.Text = MessageText;
            f.ShowDialog();

            MessageBoxResult temp = f.MessageResult;
            f.Close();
            return  MessageBoxResult.Cancel;
        }
    }
}
