using System;

namespace Lesson12_ludo
{
    /// <summary>
    /// 飞行棋
    /// 
    /// </summary>
    class Program
    {

        struct Vector2
        {
            public int posX, posY;
            public Vector2(int x, int y)
            {
                this.posX = x;
                this.posY = y;
            }
        }


        enum GameObjectTye
        {
            /// <summary>
            /// 
            /// </summary>
            Normal = 0,
            Pause = 1,
            /// <summary>
            /// 轮盘
            /// </summary>
            Roulette = 2,//轮盘
            /// <summary>
            /// 隧道tube
            /// </summary>
            Tunnel = 3,//隧道tube
            /// <summary>
            /// 地雷
            /// </summary>
            Tor = 4, //地雷
            Player1 = 5,
            Player2 = 6
        }


        struct GameObject
        {
            public Vector2 pos;
            public string icon;
            public GameObjectTye type;

            public GameObject(Vector2 pos, GameObjectTye type = GameObjectTye.Normal)
            {
                this.pos = pos;
                this.icon = "";
                this.type = type;
            }

            public void DrawIcon()
            {
                Console.SetCursorPosition(pos.posX, pos.posY);

                switch (type)
                {
                    case GameObjectTye.Normal:

                        icon = "■";
                        break;
                    case GameObjectTye.Pause:
                        Console.ForegroundColor = ConsoleColor.Red;
                        icon = "X";
                        break;
                    case GameObjectTye.Roulette:
                        Console.ForegroundColor = ConsoleColor.Green;
                        icon = "卍";
                        break;
                    case GameObjectTye.Tunnel:
                        Console.ForegroundColor = ConsoleColor.Blue;
                        icon = "▲";
                        break;
                    case GameObjectTye.Tor:
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        icon = "◎";
                        break;
                    case GameObjectTye.Player1:
                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        icon = "★";
                        break;
                    case GameObjectTye.Player2:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        icon = "☆";
                        break;
                    default:
                        break;
                }
                Console.WriteLine(icon);
                Console.ForegroundColor = ConsoleColor.Gray;
            }

        }


        struct Map
        {
            private GameObject[] mapGos;
            private int length;

            public void GetLength()
            {
                length = 116;
            }

            public void SetGameObjectData()
            {
                GetLength();
                mapGos = new GameObject[length];

                for (int i = 0; i < 30; i++)
                {

                }
            }
        }
        static void Main(string[] args)
        {
            //-
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            GameObject gameObject = new GameObject(new Vector2(5, 5), GameObjectTye.Tor);
            GameObject gameObject1 = new GameObject(new Vector2(10, 10), GameObjectTye.Player1);
            gameObject.DrawIcon();
            gameObject1.DrawIcon();

        }



    }
}
