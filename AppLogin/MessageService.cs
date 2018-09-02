using System.Windows.Forms;

namespace AppLogin
{

    public interface IMessageService
    {
        void ShowInfo(string info);
        void ShowExclamation(string Exclamation);
        void ShowError(string error);
    }

    public class MessageService : IMessageService
    {

        public void ShowInfo(string info)
        {
            MessageBox.Show(info, "Сообщение", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        public void ShowExclamation(string Exclamation)
        {
            MessageBox.Show(Exclamation,"Предупреждение",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }

        public void ShowError(string error)
        {
            MessageBox.Show(error,"Ошибка",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
    }
}
