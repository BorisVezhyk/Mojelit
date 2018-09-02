using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLogin
{
    public class CheckDGVOnException
    {


        /// <summary>
        /// The method checks Dgv on Exception. Return true if Dgv does not have exception. 
        /// </summary>
        /// <returns> </returns>
        public static bool CheckDataOnException(DataGridView DgvListDepDetails)
        {
            int countRowsWithValue = 0;
            bool checkExcept = true;
            for (int i = 0; i < DgvListDepDetails.Rows.Count - 1; i++)
            {
                try
                {
                    uint takedet = Convert.ToUInt32(DgvListDepDetails.Rows[i].Cells[8].Value);
                    if (takedet > 0)
                    {
                        checkBalanceWithTakenDetails(ref countRowsWithValue, ref checkExcept, i, takedet, DgvListDepDetails);
                    }

                }
                catch (Exception)
                {

                    MessageBox.Show("В колонке \"Взять кол-во деталей\" могут быть только положительные целочисленные значения");
                    checkExcept = false;

                }

            }

            checkExcept = CheckCountRowsOnValue(countRowsWithValue, checkExcept);

            return checkExcept;
        }


        /// <summary>
        /// Method checks rows to empty values
        /// </summary>
        /// <param name="countRowsWithValue"></param>
        /// <param name="checkExcept"></param>
        /// <returns></returns>
        private static bool CheckCountRowsOnValue(int countRowsWithValue, bool checkExcept)
        {
            if (countRowsWithValue == 0 && checkExcept)
            {
                checkExcept = false;
                MessageBox.Show("Вы не выбрали ни одной детали");
            }

            return checkExcept;
        }


        /// <summary>
        /// Method checks Balance with details taken
        /// </summary>
        /// <param name="countRowsWithValue"></param>
        /// <param name="checkExcept"></param>
        /// <param name="i"></param>
        /// <param name="takedet"></param>
        private static void checkBalanceWithTakenDetails(ref int countRowsWithValue, ref bool checkExcept, int i, uint takedet, DataGridView DgvListDepDetails)
        {
            uint balance = Convert.ToUInt32(DgvListDepDetails.Rows[i].Cells[4].Value);
            if (balance < takedet)
            {
                string error = string.Format("Вы не можете взять больше деталей, чем их есть на балансе.");
                string errArticle = string.Format("Ошибка ввода. В строке №{0} ", i + 1);

                MessageBox.Show(error, errArticle);
                checkExcept = false;
            }
            else
                countRowsWithValue++;
        }
    }
}
