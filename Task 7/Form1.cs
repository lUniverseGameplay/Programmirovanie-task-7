using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

namespace Task_7
{
    public partial class Form1 : Form
    {
        Cafedra caf = new Cafedra(new Student[200]);
        int students_on_caf_counter = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void add_student_button_Click(object sender, EventArgs e)
        {
            if (students_on_caf_counter > 200)
            {
                student_label.Text = "More than 200 students. You can't add new students. Sorry:)";
            }
            else
            {
                string[] stud_info = student_insert.Text.Split('/');

                // Проверки корректности введённых значений
                if (stud_info.Length != 3)
                {
                    student_label.Text = "Uncorrect count of values (must be 3 values divided by '/' simbol). Insert student's data like this: FIO/Speciality/GroupNumber. But no more than 200";
                }
                else
                {
                    string fio_abitur = stud_info[0];
                    string speciality_abitur = stud_info[1];
                    int group_num_abitur;
                    bool success = int.TryParse(stud_info[2], out group_num_abitur);
                    if (!success)
                    {
                        student_label.Text = "Uncorrect number of group (must be number). Insert student's data like this: FIO/Speciality/GroupNumber";
                    }
                    else
                    {
                        student_label.Text = "Insert student's data like this: FIO/Speciality/GroupNumber. But no more than 200";
                        group_num_abitur = int.Parse(stud_info[2]);
                    }
                    caf[students_on_caf_counter] = new Student(fio_abitur, speciality_abitur, group_num_abitur);
                    students_on_caf_counter++;

                    unsorted_listBox.Items.Add($"{students_on_caf_counter}. {student_insert.Text}");
                    student_insert.Text = "";

                    /* Начало полного обновления unsorted_listBox
                    unsorted_listBox.Items.Clear();
                    for (int i = 0; i < students_on_caf_counter; i++)
                    {
                        Student time_stud = caf[i];
                        string rezult = time_stud.fio + " / " + time_stud.speciality + " / " + time_stud.group_num.ToString();
                        unsorted_listBox.Items.Add(rezult);
                    }*/
                }
            }
        }
    }

    public class Student
    {
        public string fio = "Petrov Petr Petrovich";
        public string speciality = "PE";
        public int group_num = 2231122;

        public Student() { }
        public Student(string f, string spec, int group_n)
        {
            this.fio = f;
            this.speciality = spec;
            this.group_num = group_n;
        }
    }

    class Cafedra
    {
        Student[] students;

        public Cafedra(Student[] stud) => students = stud;

        public Student this[int i]
        {
            get
            {
                if (i >= 0 && i < students.Length)
                {
                    return students[i];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Out of range");
                }
            }
            set
            {
                if (i >= 0 && i < students.Length)
                {
                    students[i] = value;
                }
            }
        }
    }

    class Sorter
    {
        Stopwatch watcher = new Stopwatch();
        private int n = 0;

        public bool str_comprassion_less(string less, string more)
        {
            char[] c_less_array = less.ToLower().ToCharArray();
            char[] c_more_array = more.ToLower().ToCharArray();
            int i = 0;

            while (i < c_less_array.Length && i < c_more_array.Length)
            {
                if (Convert.ToInt32(Convert.ToString((int)c_less_array[i])) < Convert.ToInt32(Convert.ToString((int)c_more_array[i])))
                {
                    return true;
                }
                if (Convert.ToInt32(Convert.ToString((int)c_less_array[i])) > Convert.ToInt32(Convert.ToString((int)c_more_array[i])))
                {
                    return false;
                }
                i++;
            }
            return false;
        }

        public void direct_selection_method(Cafedra masive, byte length, byte mod)
        {
            Console.WriteLine("Sorting by direct selection method:");

            watcher.Start();

            for (int i = 0; i < length - 1; i++)
            {
                Student mn = masive[i];
                int ind = i;
                for (int j = i; j < length; j++)
                {
                    if (mod == 3)
                    {
                        if (mn.group_num > masive[j].group_num) { mn = masive[j]; ind = j; }
                    }
                    if (mod == 2)
                    {
                        if (str_comprassion_less(masive[j].speciality, mn.speciality)) { mn = masive[j]; ind = j; }
                    }
                    if (mod == 1)
                    {
                        if (str_comprassion_less(masive[j].fio, mn.fio)) { mn = masive[j]; ind = j; }
                    }
                }
                masive[ind] = masive[i];
                masive[i] = mn;
                n++;
            }

            watcher.Stop();

            Console.WriteLine("    Steps: " + n.ToString());
            Console.WriteLine("    Time has been spent: " + watcher.ElapsedMilliseconds.ToString() + "\n");
            watcher.Reset();
            n = 0;
        }

        public void bubble_method(Cafedra masive, byte length, byte mod)
        {
            Console.WriteLine("Sorting by direct exchange (bubble) method:");
            bool bl = true;

            watcher.Start();

            while (bl)
            {
                int counter = 0;
                for (int i = 0; i < length - 1; i++)
                {
                    if (mod == 3)
                    {
                        if (masive[i].group_num > masive[i + 1].group_num)
                        {
                            Student x = masive[i];
                            masive[i] = masive[i + 1];
                            masive[i + 1] = x;
                            counter++;
                        }
                    }
                    if (mod == 2)
                    {
                        if (str_comprassion_less(masive[i + 1].speciality, masive[i].speciality))
                        {
                            Student x = masive[i];
                            masive[i] = masive[i + 1];
                            masive[i + 1] = x;
                            counter++;
                        }
                    }
                    if (mod == 1)
                    {
                        if (str_comprassion_less(masive[i + 1].fio, masive[i].fio))
                        {
                            Student x = masive[i];
                            masive[i] = masive[i + 1];
                            masive[i + 1] = x;
                            counter++;
                        }
                    }
                }
                if (counter == 0)
                {
                    bl = false;
                }
                else
                {
                    n++;
                }
            }

            watcher.Stop();

            Console.WriteLine("    Steps: " + n.ToString());
            Console.WriteLine("    Time has been spent: " + watcher.ElapsedMilliseconds.ToString() + "\n");
            watcher.Reset();
            n = 0;
        }

        public void direct_activation_method(Cafedra masive, byte length, byte mod)
        {
            Console.WriteLine("Sorting by direct activation method:");
            watcher.Start();

            for (int i = 1; i < length; i++)
            {
                int past = i - 1;
                if (mod == 3)
                {
                    if (masive[past].group_num > masive[i].group_num)
                    {
                        int x = -1;
                        Cafedra masive2 = new Cafedra(new Student[length]);
                        for (int j = i - 1; j > -1; j--)
                        {
                            if (masive[j].group_num <= masive[i].group_num)
                            {
                                x = j;
                                break;
                            }
                        }
                        if (x == -1)
                        {
                            masive2[0] = masive[i];
                            //System.Array.Copy(masive, 0, masive2, 1, i);
                            for (int j = 0; j < i; j++) { masive2[j + 1] = masive[j]; }
                            if (i != length - 1)
                            {
                                //System.Array.Copy(masive, i+1, masive2, i+1, length - 1 - i);
                                for (int j = 0; j < length - 1 - i; j++) { masive2[i + 1 + j] = masive[i + 1 + j]; }
                            }
                        }
                        else
                        {
                            //System.Array.Copy(masive, 0, masive2, 0, x+1); //с 0 индекса до индекса меньшего объекта чем masive[i]
                            for (int j = 0; j < x + 1; j++) { masive2[j] = masive[j]; }
                            masive2[x + 1] = masive[i];  //вставляем число masive[i]
                            //System.Array.Copy(masive, x+1, masive2, x+2, i-x-1); //с индекса меньшего объекта (чем masive[i]) изначального массива вставляем количество элементов между индексами этих 2 элементов на индекс, идущий после места установки объекта masive[i]
                            for (int j = 0; j < (i - x - 1); j++) { masive2[x + 2 + j] = masive[x + 1 + j]; }
                            if (i != length - 1)
                            {
                                //System.Array.Copy(masive, i+1, masive2, i+1, length - 1 - i);
                                for (int j = 0; j < length - 1 - i; j++) { masive2[i + 1 + j] = masive[i + 1 + j]; }
                            }
                        }
                        for (int f = 0; f < length; f++)
                        {
                            masive[f] = masive2[f];
                        }
                        n++;
                    }
                }
                if (mod == 2)
                {
                    if (str_comprassion_less(masive[i].speciality, masive[past].speciality))
                    {
                        int x = -1;
                        Student[] masive2 = new Student[length];
                        for (int j = i - 1; j > -1; j--)
                        {
                            if (!str_comprassion_less(masive[i].speciality, masive[j].speciality))
                            {
                                x = j;
                                break;
                            }
                        }
                        if (x == -1)
                        {
                            masive2[0] = masive[i];
                            //System.Array.Copy(masive, 0, masive2, 1, i);
                            for (int j = 0; j < i; j++) { masive2[j + 1] = masive[j]; }
                            if (i != length - 1)
                            {
                                //System.Array.Copy(masive, i+1, masive2, i+1, length - 1 - i);
                                for (int j = 0; j < length - 1 - i; j++) { masive2[i + 1 + j] = masive[i + 1 + j]; }
                            }
                        }
                        else
                        {
                            //System.Array.Copy(masive, 0, masive2, 0, x+1); //с 0 индекса до индекса меньшего объекта чем masive[i]
                            for (int j = 0; j < x + 1; j++) { masive2[j] = masive[j]; }
                            masive2[x + 1] = masive[i];  //вставляем число masive[i]
                                                         //System.Array.Copy(masive, x+1, masive2, x+2, i-x-1); //с индекса меньшего объекта (чем masive[i]) изначального массива вставляем количество элементов между индексами этих 2 элементов на индекс, идущий после места установки объекта masive[i]
                            for (int j = 0; j < (i - x - 1); j++) { masive2[x + 2 + j] = masive[x + 1 + j]; }
                            if (i != length - 1)
                            {
                                //System.Array.Copy(masive, i+1, masive2, i+1, length - 1 - i);
                                for (int j = 0; j < length - 1 - i; j++) { masive2[i + 1 + j] = masive[i + 1 + j]; }
                            }
                        }
                        for (int f = 0; f < length; f++)
                        {
                            masive[f] = masive2[f];
                        }
                        n++;
                    }
                }
                if (mod == 1)
                {
                    if (str_comprassion_less(masive[i].fio, masive[past].fio))
                    {
                        int x = -1;
                        Student[] masive2 = new Student[length];
                        for (int j = i - 1; j > -1; j--)
                        {
                            if (!str_comprassion_less(masive[i].fio, masive[j].fio))
                            {
                                x = j;
                                break;
                            }
                        }
                        if (x == -1)
                        {
                            masive2[0] = masive[i];
                            //System.Array.Copy(masive, 0, masive2, 1, i);
                            for (int j = 0; j < i; j++) { masive2[j + 1] = masive[j]; }
                            if (i != length - 1)
                            {
                                //System.Array.Copy(masive, i+1, masive2, i+1, length - 1 - i);
                                for (int j = 0; j < length - 1 - i; j++) { masive2[i + 1 + j] = masive[i + 1 + j]; }
                            }
                        }
                        else
                        {
                            //System.Array.Copy(masive, 0, masive2, 0, x+1); //с 0 индекса до индекса меньшего объекта чем masive[i]
                            for (int j = 0; j < x + 1; j++) { masive2[j] = masive[j]; }
                            masive2[x + 1] = masive[i];  //вставляем число masive[i]
                                                         //System.Array.Copy(masive, x+1, masive2, x+2, i-x-1); //с индекса меньшего объекта (чем masive[i]) изначального массива вставляем количество элементов между индексами этих 2 элементов на индекс, идущий после места установки объекта masive[i]
                            for (int j = 0; j < (i - x - 1); j++) { masive2[x + 2 + j] = masive[x + 1 + j]; }
                            if (i != length - 1)
                            {
                                //System.Array.Copy(masive, i+1, masive2, i+1, length - 1 - i);
                                for (int j = 0; j < length - 1 - i; j++) { masive2[i + 1 + j] = masive[i + 1 + j]; }
                            }
                        }
                        for (int f = 0; f < length; f++)
                        {
                            masive[f] = masive2[f];
                        }
                        n++;
                    }
                }
            }

            watcher.Stop();

            Console.WriteLine("    Steps: " + n.ToString());
            Console.WriteLine("    Time has been spent: " + watcher.ElapsedMilliseconds.ToString() + "\n");
            watcher.Reset();
            n = 0;
        }

        public void sheiker_method(Cafedra masive, byte length, byte mod)
        {
            Console.WriteLine("Sorting by sheiker method:");
            bool bl = true;

            watcher.Start();

            while (bl)
            {
                int counter = 0;
                for (int i = 0; i < length - 1; i++)
                {
                    if (mod == 3)
                    {
                        if (masive[i].group_num > masive[i + 1].group_num)
                        {
                            Student x = masive[i];
                            masive[i] = masive[i + 1];
                            masive[i + 1] = x;
                            counter++;
                        }
                    }
                    if (mod == 2)
                    {
                        if (str_comprassion_less(masive[i + 1].speciality, masive[i].speciality))
                        {
                            Student x = masive[i];
                            masive[i] = masive[i + 1];
                            masive[i + 1] = x;
                            counter++;
                        }
                    }
                    if (mod == 1)
                    {
                        if (str_comprassion_less(masive[i + 1].fio, masive[i].fio))
                        {
                            Student x = masive[i];
                            masive[i] = masive[i + 1];
                            masive[i + 1] = x;
                            counter++;
                        }
                    }
                }
                for (int i = length - 1; i > 0; i--)
                {
                    if (mod == 3)
                    {
                        if (masive[i].group_num < masive[i - 1].group_num)
                        {
                            Student x = masive[i];
                            masive[i] = masive[i - 1];
                            masive[i - 1] = x;
                            counter++;
                        }
                    }
                    if (mod == 2)
                    {
                        if (str_comprassion_less(masive[i].speciality, masive[i - 1].speciality))
                        {
                            Student x = masive[i];
                            masive[i] = masive[i - 1];
                            masive[i - 1] = x;
                            counter++;
                        }
                    }
                    if (mod == 1)
                    {
                        if (str_comprassion_less(masive[i].fio, masive[i - 1].fio))
                        {
                            Student x = masive[i];
                            masive[i] = masive[i - 1];
                            masive[i - 1] = x;
                            counter++;
                        }
                    }
                }
                if (counter == 0)
                {
                    bl = false;
                }
                n++;
            }

            watcher.Stop();

            Console.WriteLine("    Steps: " + n.ToString());
            Console.WriteLine("    Time has been spent: " + watcher.ElapsedMilliseconds.ToString() + "\n");
            watcher.Reset();
            n = 0;
        }

        public void shell_method(Cafedra masive, int length, byte mod)
        {
            Console.WriteLine("Sorting by direct Shell's method:");

            watcher.Start();

            for (int s = length / 2; s > 0; s /= 2)
            {
                int i, j;
                for (i = s; i < length; i++)
                {
                    Student current = masive[i];
                    if (mod == 3)
                    {
                        for (j = i - s; (j > -1) && (masive[j].group_num > current.group_num); j -= s) { masive[j + s] = masive[j]; } //проходим все предыдущие элементы с шагом s, если они больше текущего (а именно masive[i]), то заменяем на шаг справа               
                        masive[j + s] = current;
                    }
                    if (mod == 2)
                    {
                        for (j = i - s; (j > -1) && str_comprassion_less(current.speciality, masive[j].speciality); j -= s) { masive[j + s] = masive[j]; }
                        masive[j + s] = current;
                    }
                    if (mod == 1)
                    {
                        for (j = i - s; (j > -1) && str_comprassion_less(current.fio, masive[j].fio); j -= s) { masive[j + s] = masive[j]; }
                        masive[j + s] = current;
                    }
                }
                n++;
            }

            watcher.Stop();

            Console.WriteLine("    Steps: " + n.ToString());
            Console.WriteLine("    Time has been spent: " + watcher.ElapsedMilliseconds.ToString() + "\n");
            watcher.Reset();
            n = 0;
        }
    }
}
