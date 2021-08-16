using System;

namespace Alphabit
{
    class Program
    {

        static void A()
        {
           
            double row_a = Convert.ToDouble(Console.ReadLine());
            double column_a = Convert.ToDouble(Console.ReadLine());
            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int row = 0; row <= row_a; row++)
            {
                for (int column = 0; column <= column_a; column++)
                {
                    if (((column == 1 || column == 5) && row != 0) ||
                         ((row == 0 || row == 3) && (column > 1 && column < 5)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void B()
        {
        

            double row_b = Convert.ToDouble(Console.ReadLine());
            double column_b = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int row = 0; row <= row_b; row++)
            {
                for (int column = 0; column <= column_b; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3 || row == 6) && (column < 5 && column > 1)) || (column == 5 && (row != 0 && row != 3 && row != 6)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void C()
        {
            

            Console.Write("\n\n");
            Console.Write("\n\n");

            double row_c = Convert.ToDouble(Console.ReadLine());
            double column_c = Convert.ToDouble(Console.ReadLine());

            for (int row = 0; row <= row_c; row++)
            {
                for (int column = 0; column <= column_c; column++)
                {
                    if ((column == 1 && (row != 0 && row != 6)) || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && (row == 1 || row == 5)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }

        static void D()
        {
           

            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\n");
            
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 5)) || (column == 5 && row != 0 && row != 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void E()
        {
            
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\n");
            
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (column == 1 || ((row == 0 || row == 6) && (column > 1 && column < 6)) || (row == 3 && column > 1 && column < 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void F()
        {
           
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());

            Console.Write("\n\n");
            
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (column == 1 || (row == 0 && column > 1 && column < 6) || (row == 3 && column > 1 && column < 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void G()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\n\n");
            
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if ((column == 1 && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5) || (row == 3 && column > 2 && column < 6) || (column == 5 && row != 0 && row != 2 && row != 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void H()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\n\n");
            
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if ((column == 1 || column == 5) || (row == 3 && column > 1 && column < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void I()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());

            

            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int  row = 0;   row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (column == 3 || (row == 0 && column > 0 && column < 6) || (row == 6 && column > 0 && column < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void J()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());

            

            Console.Write("\n\n");
           
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if ((column == 4 && row != 6) || (row == 0 && column > 2 && column < 6) || (row == 6 && column == 3) || (row == 5 && column == 2))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void K()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());


            int  j = 5, i = 0;
            Console.Write("\n\n");
            
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (column == 1 || ((row == column + 1) && column != 0))
                        Console.Write("*");

                    else if (row == i && column == j)
                    {
                        Console.Write("*");
                        i = i + 1;
                        j = j - 1;
                    }
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void L()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());

            

            Console.Write("\n\n");
            
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (column == 1 || (row == 6 && column != 0 && column < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void M()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\n\n");
            
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (column == 1 || column == 5 || (row == 2 && (column == 2 || column == 4)) || (row == 3 && column == 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void N()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\n\n");
            
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (column == 1 || column == 5 || (row == column && column != 0 && column != 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void O()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\n\n");
            
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (((column == 1 || column == 5) && row != 0 && row != 6) || ((row == 0 || row == 6) && column > 1 && column < 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void P()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\n\n");
            
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3) && column > 0 && column < 5) || ((column == 5 || column == 1) && (row == 1 || row == 2)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void Q()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());

       

            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if ((column == 1 && row != 0 && row != 6) || (row == 0 && column > 1 && column < 5) || (column == 5 && row != 0 && row != 5) || (row == 6 && column > 1 && column < 4) || (column == row - 1 && row > 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void R()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (column == 1 || ((row == 0 || row == 3) && column > 1 && column < 5) || (column == 5 && row != 0 && row < 3) || (column == row - 1 && row > 2))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void S()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
          

            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (((row == 0 || row == 3 || row == 6) && column > 1 && column < 5) || (column == 1 && (row == 1 || row == 2 || row == 6)) || (column == 5 && (row == 0 || row == 4 || row == 5)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void T()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (column == 3 || (row == 0 && column > 0 && column < 6))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void U()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (((column == 1 || column == 5) && row != 6) || (row == 6 && column > 1 && column < 5))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void V()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (((column == 1 || column == 5) && row < 5) || (row == 6 && column == 3) || (row == 5 && (column == 2 || column == 4)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void W()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (((column == 1 || column == 5) && row < 6) || ((row == 5 || row == 4) && column == 3) || (row == 6 && (column == 2 || column == 4)))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void X()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
           
            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (((column == 1 || column == 5) && (row > 4 || row < 2)) || row == column && column > 0 && column < 6 || (column == 2 && row == 4) || (column == 4 && row == 2))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void Y()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
           

            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (((column == 1 || column == 5) && row < 2) || row == column && column > 0 && column < 4 || (column == 4 && row == 2) || ((column == 3) && row > 3))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void Z()
        {
            double insert_row = Convert.ToDouble(Console.ReadLine());
            double insert_column = Convert.ToDouble(Console.ReadLine());
            

            Console.Write("\n\n");
            Console.Write("\n\n");

            for (int row = 0; row <= insert_row; row++)
            {
                for (int column = 0; column <= insert_column; column++)
                {
                    if (((row == 0 || row == 6) && column >= 0 && column <= 6) || row + column == 6)
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");
            }
            Console.Write("\n");
        }
        static void Main(string[] args)
            {
            Console.WriteLine("to pattern Alphabit normally insert 6 and 6 ");

            A();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            B();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            C();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            D();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            E();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            F();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            G();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            H();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            I();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            J();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            K();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            L();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            M();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            N();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            O();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            P();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            Q();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            R();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            S();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            T();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            U();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            V();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            W();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            X();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            Y();
            Console.WriteLine("pleases insert 2 numbers normally it should be 6 and 6");
            Z();
        }
    }
}
