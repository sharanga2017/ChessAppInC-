using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using static ChessConsole.Program;
using System.Linq;

namespace ChessConsole
{
    class Program
    {
        static void Main(string[] args)
{

            Console.WriteLine("****** WELCOME CHESS GAME ************");
            Console.WriteLine("*******************************");
            InitialisationChessBoard();
            BeginInitialisationBoard();

            PrintConsoleBoard();

            //PutWhiteColorPiece();

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("What is your move ?");

            string move = Console.ReadLine();

            PutPieceOnCellbyNotation(move, new Piece
            {
                Name = "Pion",
                Color = ColorPiece.White,
                Presentation = 'p'
            });

            PrintConsoleBoard();

            Console.ReadKey();


        }

        public static Dictionary<int, char> position = new Dictionary<int, char>();


        public static Dictionary<int, Piece> pieces = new Dictionary<int, Piece>();


        void movePiece(string move, Piece piece)
        {
            //   e2-e4



        }

        public static void PrintConsoleBoard()
        {
            int i = 0;
            foreach (var item in position)
            {
                if (item.Key % 8 == 0)
                {
                    Console.WriteLine();
                }

                if (pieces[i] != null)
                {
                    pieces[i].ToShow();
                }
                else
                {
                    Console.Write(item.Value);
                }

                
                i++;
            }


           
        }
        public static void InitialisationChessBoard()
        {
            int[] collection = new int[64];
            for (int i = 0; i < 64; i++)
            {
                collection[i] = i;
            }
            foreach (var item in collection)
            {
                position.Add(item, '*');
            }                  
        }

        public static void PutPieceOnCellbyIndex(int index, Piece piece)
        {

            pieces[index] =  piece;
                
           
        }


        public static void PutPieceOnCellbyNotation(string str, Piece piece)        
        {
            char ch0 = str[0];
            int ver0 = (int)Char.GetNumericValue(str[1]);


            char ch1 = str[2];
            int ver1 = (int)Char.GetNumericValue(str[3]);


           
            PutPieceOnCellbyNotation(ch1, ver1, piece);
            PutPieceOnCellbyNotation(ch0, ver0, null);

        }

        public static void PutPieceOnCellbyNotation(char hor, int ver, Piece piece)
        {
            int index = findIndexByNotation(hor, ver);

            PutPieceOnCellbyIndex(index, piece);
               
               
           
        }

        public static int findIndexByNotation(char hor, int ver)
        {

            int b = 8 * (8 - ver);

            switch (hor)
            {
                case 'a' : return 0 + b;            
               case 'b' : return 1 + b;
               case 'c' : return 2 + b; 
               case 'd' : return 3 + b; 
               case 'e' : return 4 + b; 
               case 'f' : return 5 + b;
               case 'g' : return 6 + b;
               case 'h' : return 7 + b;
        }
            return 65;
        }     
            

        public static void BeginInitialisationBoard()
        {
            PutPieceOnCellbyNotation('a', 8, new Piece
            {
                Name = "Tour",
                Color = ColorPiece.Black,
                Presentation = 'T'
            }) ;

            PutPieceOnCellbyNotation('b', 8, new Piece
            {
                Name = "Cavalier",
                Color = ColorPiece.Black,
                Presentation = 'C'
            });
            PutPieceOnCellbyNotation('c', 8, new Piece
            {
                Name = "Fou",
                Color = ColorPiece.Black,
                Presentation = 'F'
            });
            PutPieceOnCellbyNotation('d', 8, new Piece
            {
                Name = "Dame",
                Color = ColorPiece.Black,
                Presentation = 'D'
            });
            PutPieceOnCellbyNotation('e', 8, new Piece
            {
                Name = "Roi",
                Color = ColorPiece.Black,
                Presentation = 'R'
            });           
            
            PutPieceOnCellbyNotation('f', 8, new Piece
            {
                Name = "Fou",
                Color = ColorPiece.Black,
                Presentation = 'F'
            });
            PutPieceOnCellbyNotation('g', 8, new Piece
            {
                Name = "Cavalier",
                Color = ColorPiece.Black,
                Presentation = 'C'
            });
            PutPieceOnCellbyNotation('h', 8, new Piece
            {
                Name = "Tour",
                Color = ColorPiece.Black,
                Presentation = 'T'
            });

          


            for (int i = 8; i <= 15; i++)
            {
                PutPieceOnCellbyIndex(i, new Piece
                {
                    Name = "Pion",
                    Color = ColorPiece.Black,
                    Presentation = 'p'
                });
            }

            for (int i = 16; i <= 47; i++)
            {
                PutPieceOnCellbyIndex(i, null);
            }

            for (int i = 48; i <= 55; i++)
            {
                PutPieceOnCellbyIndex(i, new Piece
                {
                    Name = "Pion",
                    Color = ColorPiece.White,
                    Presentation = 'p'
                });
            }

            PutPieceOnCellbyNotation('a', 1, new Piece
            {
                Name = "Tour",
                Color = ColorPiece.White,
                Presentation = 'T'
            });
            PutPieceOnCellbyNotation('b', 1, new Piece
            {
                Name = "C",
                Color = ColorPiece.White,
                Presentation = 'C'
            });
            PutPieceOnCellbyNotation('c', 1, new Piece
            {
                Name = "Fou",
                Color = ColorPiece.White,
                Presentation = 'F'
            });
            PutPieceOnCellbyNotation('d', 1, new Piece
            {
                Name = "Dame",
                Color = ColorPiece.White,
                Presentation = 'D'
            });
            PutPieceOnCellbyNotation('e', 1, new Piece
            {
                Name = "Roi",
                Color = ColorPiece.White,
                Presentation = 'R'
            });
            PutPieceOnCellbyNotation('f', 1, new Piece
            {
                Name = "Fou",
                Color = ColorPiece.White,
                Presentation = 'F'
            });
            PutPieceOnCellbyNotation('g', 1, new Piece
            {
                Name = "Cavalier",
                Color = ColorPiece.White,
                Presentation = 'C'
            });
            PutPieceOnCellbyNotation('h', 1, new Piece
            {
                Name = "Tour",
                Color = ColorPiece.White,
                Presentation = 'T'
            });
        }       
    }

    public class Piece
    {
        public ColorPiece Color { get; set; }
        public string Name { get; set; }

        public char Presentation { get; set; }

        public Piece()
        {

        }
        public Piece(string name, char presentation, ColorPiece color)
        {
            Name = name;
            Presentation = presentation;
            Color = color;
        }

        public void ToShow()
        {

            if (Color == ColorPiece.Black)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write(Presentation);
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.Write(Presentation);
            }


        }
    }


    public enum ColorPiece
    {
        White, Black
    }


}
