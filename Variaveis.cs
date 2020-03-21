using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pong
{
    class Variaveis
    {
        public static string player1Name = Environment.UserName;
        public static string player2Name = "Player2";

        public static bool singlePlayer = true;

        public static Color player1Color = Color.White;
        public static Color player2Color = Color.White;
        public static Color ballColor = Color.White;

        public static int bounceStreakLimit = 5;
        public static int winScore = 5;

        public static int Difficulty = 0;
        public static string DifficultyString = "Fácil";

        public static bool fullScreen = false;
        public static bool sounds = true;

        
        //Obter a pasta de instalação
        static string appFileName = Environment.GetCommandLineArgs()[0];
        static string directory = Path.GetDirectoryName(appFileName);
        static string fileName = "/HistoricoJogos.txt";

        //A variavel filePath vai ser igual à pasta de instalação + o nome do ficheiro
        public static string filePath = directory + fileName;
        

    }
}
