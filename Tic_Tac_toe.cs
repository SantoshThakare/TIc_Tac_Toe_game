using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_board
{
    public class Tic_Tac_toe
    {    
        public void Tac()
        {
            Console.WriteLine("Welcome to TicTacToe");
            char[] grid = new char[10];

            for (int i = 1; i < 10; i++)
            {
                grid[i] = ' ';
            }
        }
        public void inputXorO()
        {
            Console.WriteLine("Enter  the X or O");
            char entry = Convert.ToChar(Console.ReadLine());
        }
    }
        
}
