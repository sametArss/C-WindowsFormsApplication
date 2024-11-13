using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace YiginÖdev
{
    public class Islemler
    {

        public Yigin bas;
        public Islemler()
        {
            bas = null;
        }

        int a = 0;
        
        public void Ekle(string test)
        { 

            for (int i = 0; i < test.Length; i++)
            {
                if (test[i] == '(' || test[i] == '[' || test[i] == '{')
                {

                    Yigin yeniYigin = new Yigin(test[i]);
                    yeniYigin.next = bas;
                    bas = yeniYigin;
                    a++;
                }
            }
        }



    public void Sil(string test)
    {

        if (bas == null)
        {

            MessageBox.Show("Liste boşş");
            return;

        }
        else
        {
             int kontrol = 0;


               
                    for (int i = 0; i < test.Length; i++)

                    {

                        if (test[i] == ')' || test[i] == ']' || test[i] == '}')
                        {
                            kontrol++;

                            if (a == 0)
                            {
                                break;
                            }


                            if (test[i] == ')' && bas.islem == '(')
                            {
                                a = a - 1;
                                bas = bas.next;
                                kontrol--;


                            }

                            else if (test[i] == ']' && bas.islem == '[')
                            {
                                a = a - 1;
                                bas = bas.next;
                                kontrol--;
                            }

                            else if (test[i] == '}' && bas.islem == '{')
                            {
                                a = a - 1;
                                bas = bas.next;
                                kontrol--;

                            }

                        }
                    }

                

            if (bas == null && kontrol ==0)
            {
                MessageBox.Show("Girdiğniz parentezler tam ");
            }
            else
            {
                MessageBox.Show("Girdiğniz parentezler Eksik ");
            }


        }
    }
}


}