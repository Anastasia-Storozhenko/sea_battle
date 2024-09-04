
using System.Drawing;
using System.Runtime.InteropServices;

class Field
{
    private int[,] board = new int[10, 10];
    public Field(int[,] board)
    {
        this.board = board;
    }
    public int[,] GetBoard()
    {
        return board;
    }
   

    public void reservation(int x, int y, int shipId, int reserveId)
    {
        x = x - 1; 
        y = y - 1;
        if (x >= 0 && x < board.GetLength(0) && y >= 0 && y < board.GetLength(1))
        {
            board[x, y] = shipId;
            ReserveField(x - 1, y, reserveId); 
            ReserveField(x + 1, y, reserveId);
            ReserveField(x, y - 1, reserveId); 
            ReserveField(x, y + 1, reserveId); 
            ReserveField(x - 1, y - 1, reserveId); 
            ReserveField(x - 1, y + 1, reserveId); 
            ReserveField(x + 1, y - 1, reserveId); 
            ReserveField(x + 1, y + 1, reserveId); 
        }
    }

    public void reservationTwo(int startx, int starty, int endx, int endy, int shipId, int reserveId)
    {
        startx = startx - 1;
        starty = starty - 1;
        endx = endx - 1;
        endy = endy - 1;
        if (startx >= 0 && startx < board.GetLength(0) && starty >= 0 && starty < board.GetLength(1) &&
       endx >= 0 && endx < board.GetLength(0) && endy >= 0 && endy < board.GetLength(1))
        {

            ReserveField(startx - 1, starty - 1, reserveId); 
            ReserveField(startx - 1, starty, reserveId);
            ReserveField(startx - 1, starty + 1, reserveId); 
            ReserveField(startx, starty - 1, reserveId); 
            ReserveField(startx, starty + 1, reserveId);
            ReserveField(startx + 1, starty - 1, reserveId); 
            ReserveField(startx + 1, starty, reserveId); 
            ReserveField(startx + 1, starty + 1, reserveId); 

            ReserveField(endx - 1, endy - 1, reserveId); 
            ReserveField(endx - 1, endy, reserveId); 
            ReserveField(endx - 1, endy + 1, reserveId); 
            ReserveField(endx, endy - 1, reserveId); 
            ReserveField(endx, endy + 1, reserveId);
            ReserveField(endx + 1, endy - 1, reserveId); 
            ReserveField(endx + 1, endy, reserveId); 
            ReserveField(endx + 1, endy + 1, reserveId);
        }
    }

    public void reservationThree(int startx, int starty, int midx, int midy, int endx, int endy, int shipId, int reserveId)
    {
        startx = startx - 1;
        starty = starty - 1;
        midx = midx - 1;
        midy = midy - 1;
        endx = endx - 1;
        endy = endy - 1;
        if (startx >= 0 && startx < board.GetLength(0) && starty >= 0 && starty < board.GetLength(1) &&
               midx >= 0 && midx < board.GetLength(0) && midy >= 0 && midy < board.GetLength(1) &&
               endx >= 0 && endx < board.GetLength(0) && endy >= 0 && endy < board.GetLength(1))
        {
            ReserveField(startx - 1, starty - 1, reserveId);
            ReserveField(startx - 1, starty, reserveId);
            ReserveField(startx - 1, starty + 1, reserveId);
            ReserveField(startx, starty - 1, reserveId);
            ReserveField(startx, starty + 1, reserveId);
            ReserveField(startx + 1, starty - 1, reserveId);
            ReserveField(startx + 1, starty, reserveId);
            ReserveField(startx + 1, starty + 1, reserveId);

            ReserveField(midx - 1, midy - 1, reserveId);
            ReserveField(midx - 1, midy, reserveId);
            ReserveField(midx - 1, midy + 1, reserveId);
            ReserveField(midx, midy - 1, reserveId);
            ReserveField(midx, midy + 1, reserveId);
            ReserveField(midx + 1, midy - 1, reserveId);
            ReserveField(midx + 1, midy, reserveId);
            ReserveField(midx + 1, midy + 1, reserveId);

            ReserveField(endx - 1, endy - 1, reserveId);
            ReserveField(endx - 1, endy, reserveId);
            ReserveField(endx - 1, endy + 1, reserveId);
            ReserveField(endx, endy - 1, reserveId);
            ReserveField(endx, endy + 1, reserveId);
            ReserveField(endx + 1, endy - 1, reserveId);
            ReserveField(endx + 1, endy, reserveId);
            ReserveField(endx + 1, endy + 1, reserveId);
        }
    }
    public void reservationFour(int startx, int starty, int mid1x, int mid1y, int mid2x, int mid2y, int endx, int endy, int shipId, int reserveId)
    {
        startx = startx - 1;
        starty = starty - 1;
        mid1x = mid1x - 1;
        mid1y = mid1y - 1;
        mid2x = mid2x - 1;
        mid2y = mid2y - 1;
        endx = endx - 1;
        endy = endy - 1;

        if (startx >= 0 && startx < board.GetLength(0) && starty >= 0 && starty < board.GetLength(1) &&
            mid1x >= 0 && mid1x < board.GetLength(0) && mid1y >= 0 && mid1y < board.GetLength(1) &&
            mid2x >= 0 && mid2x < board.GetLength(0) && mid2y >= 0 && mid2y < board.GetLength(1) &&
            endx >= 0 && endx < board.GetLength(0) && endy >= 0 && endy < board.GetLength(1))
        {
            
            ReserveField(startx - 1, starty - 1, reserveId);
            ReserveField(startx - 1, starty, reserveId);
            ReserveField(startx - 1, starty + 1, reserveId);
            ReserveField(startx, starty - 1, reserveId);
            ReserveField(startx, starty + 1, reserveId);
            ReserveField(startx + 1, starty - 1, reserveId);
            ReserveField(startx + 1, starty, reserveId);
            ReserveField(startx + 1, starty + 1, reserveId);

            ReserveField(mid1x - 1, mid1y - 1, reserveId);
            ReserveField(mid1x - 1, mid1y, reserveId);
            ReserveField(mid1x - 1, mid1y + 1, reserveId);
            ReserveField(mid1x, mid1y - 1, reserveId);
            ReserveField(mid1x, mid1y + 1, reserveId);
            ReserveField(mid1x + 1, mid1y - 1, reserveId);
            ReserveField(mid1x + 1, mid1y, reserveId);
            ReserveField(mid1x + 1, mid1y + 1, reserveId);

           
            ReserveField(mid2x - 1, mid2y - 1, reserveId);
            ReserveField(mid2x - 1, mid2y, reserveId);
            ReserveField(mid2x - 1, mid2y + 1, reserveId);
            ReserveField(mid2x, mid2y - 1, reserveId);
            ReserveField(mid2x, mid2y + 1, reserveId);
            ReserveField(mid2x + 1, mid2y - 1, reserveId);
            ReserveField(mid2x + 1, mid2y, reserveId);
            ReserveField(mid2x + 1, mid2y + 1, reserveId);

           
            ReserveField(endx - 1, endy - 1, reserveId);
            ReserveField(endx - 1, endy, reserveId);
            ReserveField(endx - 1, endy + 1, reserveId);
            ReserveField(endx, endy - 1, reserveId);
            ReserveField(endx, endy + 1, reserveId);
            ReserveField(endx + 1, endy - 1, reserveId);
            ReserveField(endx + 1, endy, reserveId);
            ReserveField(endx + 1, endy + 1, reserveId);
        }
    }

    public void ReserveField( int x, int y, int reserveId)
    {
        if (x >= 0 && x < board.GetLength(0) && y >= 0 && y < board.GetLength(1))
        {
            if (board[x, y] == 0)
            {
                board[x, y] = reserveId;

            }
           
        }

    }
    
    public void PrintBoard(int[,] board)
    {
        int size = board.GetLength(0);
        Console.Write("   ");
        for (int i=1; i<=size; i++)
        {
            Console.Write($" {i,2} ");
        }
        Console.WriteLine();

        Console.Write("   ");
        for (int i = 0; i < board.GetLength(0); i++)
        {
            Console.Write(" ---");
        }
        Console.WriteLine();

       
        for (int i = 0; i < size; i++)
        {
           
            Console.Write($"{i+1,3} ");

            for (int j = 0; j < size; j++)
            {
                char cellChar=' ';
                if (board[i, j] == 0)
                {
                    cellChar = ' ';
                }
                else if (board[i, j] == 1)
                {
                    cellChar = 'O';
                }
                else if (board[i,j]==2)      
                {
                    cellChar = '^';
                }
               
                Console.Write($"| {cellChar} ");
            }
            Console.WriteLine("|");
            

            Console.Write("   ");
            for (int j = 0; j < size; j++)
            {
                Console.Write(" ---");
            }
            Console.WriteLine();
        }
        Console.Write("  ");
        for (int i = 1; i <= size; i++)
        {
            Console.Write($" { i,3 }");
        }
        Console.WriteLine();

    }

    public void PrintBoard1(int[,] board)
    {
        int size = board.GetLength(0);
        Console.Write("   ");
        for (int i = 1; i <= size; i++)
        {
            Console.Write($" {i,2} ");
        }
        Console.WriteLine();

        Console.Write("   ");
        for (int i = 0; i < board.GetLength(0); i++)
        {
            Console.Write(" ---");
        }
        Console.WriteLine();


        for (int i = 0; i < size; i++)
        {

            Console.Write($"{i + 1,3} ");

            for (int j = 0; j < size; j++)
            {
                char cellChar = ' ';
                if (board[i, j] == 0)
                {
                    cellChar = ' ';
                }
                else if (board[i, j] == 1)
                {
                    cellChar = ' ';
                }
                else if (board[i, j] == 2)
                {
                    cellChar = ' ';
                }
                else if (board[i, j] == 3)
                {
                    cellChar = 'X';
                }
                Console.Write($"| {cellChar} ");
            }
            Console.WriteLine("|");


            Console.Write("   ");
            for (int j = 0; j < size; j++)
            {
                Console.Write(" ---");
            }
            Console.WriteLine();
        }
        Console.Write("  ");
        for (int i = 1; i <= size; i++)
        {
            Console.Write($" {i,3}");
        }
        Console.WriteLine();

    }

}



abstract class Ship
{
    private string name { get; set; }
    private int cells { get; set; }

    public Ship()
    {

    }

    public Ship(string name, int cells)
    {
        this.name = name;
        this.cells = cells;
        
    }
    public abstract void Die(Field field, int px, int py, int dieid);

 

}

class OneShips: Ship
{
    private int x { get; set; }
    private int y { get; set; }

  
  
    public OneShips(string name, int count_cells, int X, int Y)
        : base(name, count_cells)
    {
 
        this.x = X -1 ;
        this.y = Y -1;
          
    }
    public OneShips()
    {
    }
   
    public void PlaceShip(Field field, int shipId, int reserveId)
    {
        int[,] board = field.GetBoard();
       

        if (x < 0 || x >= board.GetLength(0) || y < 0 || y >= board.GetLength(1))
        {
            throw new ArgumentOutOfRangeException("Coordinates are out of bounds!");
        }

        if (board[x, y] == reserveId)
        {
            throw new InvalidOperationException("Cannot place a ship on a reserved field!");
        }

        if (board[x, y] == shipId)
        {
            throw new InvalidOperationException("Cannot place a ship on a ship field!");

        }

        board[x, y] = shipId;

    }

    public override void Die(Field filed,int px, int py, int dieid)
    {
        px = px - 1;
        py = py - 1;
        int[,] board= filed.GetBoard();
        if(px==x && py == y)
        {
            board[x, y] = dieid;
           
            Console.WriteLine("Kill");

        }
        
        
        

    }
   
   
}



class TwoShips : Ship
{
    
    private int startx { get; set; }
    private int starty { get; set; }
    private int endx { get; set; }
    private int endy { get; set; }

   

   

    public TwoShips(string name, int count_cells, int startX, int startY, int endX, int endY)
        : base(name, count_cells)
    {
      
        this.startx = startX - 1;
        this.starty = startY -1;
        this.endx = endX - 1;
        this.endy = endY -1;
    }

    public TwoShips()
    {
    }

   
    public void PlaceShipTwo(Field field, int shipId, int reserveId)
    {
        int[,] board = field.GetBoard();
        

        if (endx < 0 && startx < 0 || endx >= board.GetLength(0) && startx >= board.GetLength(0) || endy < 0 && starty < 0 || endy >= board.GetLength(1) && starty >= board.GetLength(1))
        {
            throw new ArgumentOutOfRangeException("Coordinates are out of bounds!");
        }

        if (!((startx == endx && Math.Abs(starty - endy) == 1) || (starty == endy && Math.Abs(startx - endx) == 1)))
        {
            throw new InvalidOperationException("Invalid ship placement.The ship must occupy adjacent cells either horizontally or vertically.");
        }

        if (board[endx, endy] == reserveId || board[startx, starty] == reserveId)
        {
            throw new InvalidOperationException("Cannot place a ship on a reserved field!");
        }

        if (board[endx, endy] == shipId || board[startx, starty] == shipId)
        {
            throw new InvalidOperationException("Cannot place a ship on a ship field!");

        }
        board[startx, starty] = shipId;
        board[endx, endy] = shipId;

    }

    public override void Die(Field filed, int px, int py, int dieid)
    {
        px = px - 1;
        py = py - 1;
        int[,] board = filed.GetBoard();
        if (px == startx && py == starty)
        {
            board[startx, starty] = dieid;

        }
        else if (px == endx && py == endy)
        {
                board[startx, starty] = dieid;

        }
        else if(px == endx && py == endy && px == startx && py == starty)
        {
            Console.WriteLine("Kill");
        }




    }


}

class ThreeShips : Ship
{
    
    private int startx { get; set; }
    private int starty { get; set; }
    private int midx { get; set; }
    private int midy { get; set; }

    private int endx { get; set; }
    private int endy { get; set; }

   
    public ThreeShips(string name, int count_cells, int startX, int startY, int midX, int midY, int endX, int endY)
       : base(name, count_cells)
    {
        this.startx = startX - 1;
        this.starty = startY - 1;
        this.midx = midX - 1;
        this.midy = midY - 1;
        this.endx = endX - 1;
        this.endy = endY - 1;
    }


    public ThreeShips()
    {
    }
  
    public void PlaceShipThree(Field field, int shipId, int reserveId)
    {
        int[,] board= field.GetBoard();
     

        if (endx < 0 || endx >= board.GetLength(0) || startx < 0 || startx >= board.GetLength(0) ||
      midx < 0 || midx >= board.GetLength(0) || endy < 0 || endy >= board.GetLength(1) ||
      starty < 0 || starty >= board.GetLength(1) || midy < 0 || midy >= board.GetLength(1))
        {
            throw new ArgumentOutOfRangeException("Coordinates are out of bounds!");
        }

        if (!((startx == midx && midx == endx && Math.Abs(starty - midy) == 1 && Math.Abs(midy - endy) == 1) ||
           (starty == midy && midy == endy && Math.Abs(startx - midx) == 1 && Math.Abs(midx - endx) == 1)))
        {
            throw new InvalidOperationException("Invalid ship placement.The ship must occupy adjacent cells either horizontally or vertically.");
        }

        if (board[endx, endy] == reserveId || board[startx, starty] == reserveId || board[midx, midy] == reserveId)
        {
            throw new InvalidOperationException("Cannot place a ship on a reserved field!");
        }

        if (board[endx, endy] == shipId || board[startx, starty] == shipId || board[midx, midy] == shipId)
        {
            throw new InvalidOperationException("Cannot place a ship on a ship field!");

        }
        board[startx, starty] = shipId;
        board[midx, midy] = shipId;
        board[endx, endy] = shipId;

    }
    public override void Die(Field field, int px, int py, int dieId)
    {
        px -= 1;
        py -= 1;
        int[,] board = field.GetBoard();

       
            if (px == startx && py == starty)
            {
                
                board[startx, starty] = dieId;
                
            }
            else if (px == midx && py == midy)
            {
                
                board[midx, midy] = dieId;
               
            }
            else if (px == endx && py == endy)
            {
                
                board[endx, endy] = dieId;
                
            }
            else if(px == startx && py == starty && px == midx && py == midy && px == endx && px == endy)
        {
            Console.WriteLine("Kill");
        }
        
       
    }

    
}


class FourShips : Ship
{

    private int startx { get; set; }
    private int starty { get; set; }
    private int mid1x { get; set; }
    private int mid1y{ get; set; }
    private int mid2x { get; set; }
    private int mid2y { get; set; }

    private int endx { get; set; }
    private int endy { get; set; }

   
    public FourShips(string name, int count_cells, int startX, int startY, int mid1X, int mid1Y, int mid2X, int mid2Y, int endX, int endY)
       : base(name, count_cells)
       
    {
        this.startx = startX - 1;
        this.starty = startY - 1;
        this.mid1x = mid1X - 1;
        this.mid1y = mid1Y - 1;
        this.mid2x = mid2X - 1;
        this.mid2y = mid2Y - 1;
        this.endx = endX - 1;
        this.endy = endY - 1;

    }

    public FourShips()
    {
    }

    public void PlaceShipFour(Field field ,int shipId, int reserveId)
    {
        int[,] board= field.GetBoard();
       

        if (endx < 0 || endx >= board.GetLength(0) || startx < 0 || startx >= board.GetLength(0) ||
        mid1x < 0 || mid1x >= board.GetLength(0) || mid2x < 0 || mid2x >= board.GetLength(0) ||
        endy < 0 || endy >= board.GetLength(1) || starty < 0 || starty >= board.GetLength(1) ||
        mid1y < 0 || mid1y >= board.GetLength(1) || mid2y < 0 || mid2y >= board.GetLength(1))
        {
            throw new ArgumentOutOfRangeException("Coordinates are out of bounds!");
        }
        if (!((startx == mid1x && mid1x == mid2x && mid2x == endx && Math.Abs(starty - mid1y) == 1 && Math.Abs(mid1y - mid2y) == 1 && Math.Abs(mid2y - endy) == 1) ||
          (starty == mid1y && mid1y == mid2y && mid2y == endy && Math.Abs(startx - mid1x) == 1 && Math.Abs(mid1x - mid2x) == 1 && Math.Abs(mid2x - endx) == 1)))
        {
            throw new InvalidOperationException("Invalid ship placement. The ship must occupy four adjacent cells either horizontally or vertically.");
        }
        if (board[endx, endy] == reserveId || board[startx, starty] == reserveId || board[mid1x, mid1y] == reserveId || board[mid2x, mid2y] == reserveId)
        {
            throw new InvalidOperationException("Cannot place a ship on a reserved field!");
        }
        if (board[endx, endy] == shipId || board[startx, starty] == shipId || board[mid1x, mid1y] == shipId || board[mid2x, mid2y] == shipId)
        {
            throw new InvalidOperationException("Cannot place a ship on a ship field!");
        }
        board[startx, starty] = shipId;
        board[mid1x, mid1y] = shipId;
        board[mid2x, mid2y] = shipId;
        board[endx, endy] = shipId;

    }

  

    public override void Die(Field field, int px, int py, int dieId)
    {
        px -= 1;
        py -= 1;
        int[,] board = field.GetBoard();

            if (px == startx && py == starty)
            {
                
                board[startx, starty] = dieId;
                
            }
            else if (px == mid1x && py == mid1y)
            {
               
                board[mid1x, mid1y] = dieId;
                
            }
            else if (px == mid2x && py == mid2y)
            {
              
                board[mid2x, mid2y] = dieId;
                
            }
            else if (px == endx && py == endy)
            {
                
                board[endx, endy] = dieId;
                
            }
            else if (px == startx && py == starty && px == mid1x && py == mid1y&& px == mid2x && py == mid2y && px == endx && py == endy)
        {
            Console.WriteLine("Kill");
        }
        

        
       
    }

   
}




class Program
{
    public static void Main(string[] args)
    {

        int shipId = 1;
        int reserveId = 2;
        int dieid = 3;
        int[,] board = new int[10, 10];
        Field field = new Field(board);

        List<Ship> shipList = new List<Ship>();

        Console.WriteLine("Four cells ships");
        Console.WriteLine("Enter one cell x");
        int x4_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y4_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell x");
        int x4_2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y4_2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell x");
        int x4_3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y4_3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell x");
        int x4_4 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y4_4 = int.Parse(Console.ReadLine());
        FourShips fourShips = new FourShips("FourShip", 4, x4_1, y4_1, x4_2, y4_2, x4_3, y4_3, x4_4, y4_4);
        fourShips.PlaceShipFour(field, shipId, reserveId);
        field.reservationFour(x4_1, y4_1, x4_2, y4_2, x4_3, y4_3, x4_4, y4_4, shipId, reserveId);
        field.PrintBoard(board);

        shipList.Add(fourShips);


        Console.WriteLine("Three cells ships");
        Console.WriteLine("Enter one cell x");
        int x3_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y3_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell x");
        int x3_2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y3_2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell x");
        int x3_3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y3_3 = int.Parse(Console.ReadLine());
        ThreeShips threeShips = new ThreeShips("ThreeCellsFirst", 3, x3_1, y3_1, x3_2, y3_2, x3_3, y3_3);
        threeShips.PlaceShipThree(field, shipId, reserveId);
        field.reservationThree(x3_1, y3_1, x3_2, y3_2, x3_3, y3_3, shipId, reserveId);
        field.PrintBoard(board);

        shipList.Add(threeShips);

        Console.WriteLine("Three cells ships");
        Console.WriteLine("Enter one cell x");
        int x3_11 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y3_11 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell x");
        int x3_22 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y3_22 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell x");
        int x3_33 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y3_33 = int.Parse(Console.ReadLine());
        ThreeShips threeShips2 = new ThreeShips("ThreeCellsFirst", 3, x3_11, y3_11, x3_22, y3_22, x3_33, y3_33);
        threeShips2.PlaceShipThree(field, shipId, reserveId);
        field.reservationThree(x3_11, y3_11, x3_22, y3_22, x3_33, y3_33, shipId, reserveId);
        field.PrintBoard(board);


        shipList.Add(threeShips2);



        Console.WriteLine("Two cells ships");
        Console.WriteLine("Enter one cell x");
        int x2_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y2_1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell x");
        int x2_2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y2_2 = int.Parse(Console.ReadLine());
        TwoShips twoShips = new TwoShips("TwoCellsFirst", 2, x2_1, y2_1, x2_2, y2_2);
        twoShips.PlaceShipTwo(field, shipId, reserveId);
        field.reservationTwo(x2_1, y2_1, x2_2, y2_2, shipId, reserveId);
        field.PrintBoard(board);

        shipList.Add(twoShips);

        Console.WriteLine("Enter one cell x");
        int x2_11 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y2_11 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell x");
        int x2_22 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y2_22 = int.Parse(Console.ReadLine());
        TwoShips twoShips2 = new TwoShips("TwoCellsFirst", 2, x2_11, y2_11, x2_22, y2_22);
        twoShips2.PlaceShipTwo(field, shipId, reserveId);
        field.reservationTwo(x2_11, y2_11, x2_22, y2_22, shipId, reserveId);
        field.PrintBoard(board);

        shipList.Add(twoShips2);



        Console.WriteLine("Enter one cell x");
        int x2_111 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y2_111 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell x");
        int x2_222 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y2_222 = int.Parse(Console.ReadLine());
        TwoShips twoShips22 = new TwoShips("TwoCellsFirst", 2, x2_111, y2_111, x2_222, y2_222);
        twoShips22.PlaceShipTwo(field, shipId, reserveId);
        field.reservationTwo(x2_111, y2_111, x2_222, y2_222, shipId, reserveId);
        field.PrintBoard(board);

        shipList.Add(twoShips22);


        Console.WriteLine("One cell ships");
        Console.WriteLine("Enter one cell x");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y = int.Parse(Console.ReadLine());
        OneShips oneShip = new OneShips("OneCellsFirst", 1, x, y);
        oneShip.PlaceShip(field, shipId, reserveId);
        field.reservation(x, y, shipId, reserveId);
        field.PrintBoard(board);
        shipList.Add(oneShip);


        Console.WriteLine("Enter one cell x");
        int x1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y1 = int.Parse(Console.ReadLine());
        OneShips oneShip1 = new OneShips("OneCellsFirst", 1, x1, y1);
        oneShip1.PlaceShip(field, shipId, reserveId);
        field.reservation(x1, y1, shipId, reserveId);
        field.PrintBoard(board);
        shipList.Add(oneShip1);

        Console.WriteLine("Enter one cell x");
        int x2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y2 = int.Parse(Console.ReadLine());
        OneShips oneShip2 = new OneShips("OneCellsFirst", 1, x2, y2);
        oneShip2.PlaceShip(field, shipId, reserveId);
        field.reservation(x2, y2, shipId, reserveId);
        field.PrintBoard(board);
        shipList.Add(oneShip2);

        Console.WriteLine("Enter one cell x");
        int x3 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter one cell y");
        int y3 = int.Parse(Console.ReadLine());
        OneShips oneShip3 = new OneShips("OneCellsFirst", 1, x3, y3);
        oneShip3.PlaceShip(field, shipId, reserveId);
        field.reservation(x3, y3, shipId, reserveId);
        field.PrintBoard(board);
        shipList.Add(oneShip3);

        Console.WriteLine("The ships are placed");
        //Console.Clear();

        field.PrintBoard1(board);
        int flag = 0;   

        while (flag==0)
        {
            Console.WriteLine("Enter the coordinates to attack:");
            Console.Write("Enter x: ");
            int attackX = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int attackY = int.Parse(Console.ReadLine());
            
            foreach (var ship in shipList)
            {
               
                ship.Die(field, attackX, attackY, dieid);
                   
               
            }
            


            field.PrintBoard1(board);
            Console.WriteLine("Do you want to end(enter 0)");
            int a = int.Parse(Console.ReadLine());
            if (a == 0)
            {
                flag = 1;
            }
            

        }





    }
}


