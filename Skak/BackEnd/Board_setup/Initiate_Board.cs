namespace Skak.BackEnd.Board_setup
{
    public class InitiateBoard()
    {
        public void boardSize() {
            //variables
        int height = 8;
        int width = 8;
        //a tiny bit of caluclation
        for (int i = 0; i<height; i++)//looper igennem rækker
                for (int j = 0; j < width; j++)//looper igennem kolonner
                    if ((i+j)%2==0)
                    {
                        Console.Write("X"); //white square
                    }
                    else
                        Console.Write("0"); //black square
                 Console.WriteLine();//New line 
        }
        
    }

}
