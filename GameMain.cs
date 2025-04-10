using KGA_OOPConsoleProject.Scenes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    /// <summary>
    /// GameMain Class은 처음부터 끝까지 사용할 Class이므로 static으로 선언
    /// </summary>
    public static class GameMain
    {
        // 게임 오버가 되면 게임을 종료하도록 설정
        public static bool gameOver;

        // Scene들이 많이 있으므로 Dictionary로 관리
        // Scene의 이름으로 관리하기 위해 string, Scene 설정.
        private static Dictionary<string, Scene> sceneDic;

        // Scene은 현재 Scene이다 설정
        private static Scene curScene;

        // 변경된 Scene 설정
        public static string beforeScene;

        // 게임 내에서 플레이어를 건들지 못하게 private 선언 후
        // property를 사용해 읽기로 구현
        private static Player player;
        public static Player Player { get { return player; } }

        /// <summary>
        /// 게임 시작
        /// </summary>
        public static void Start()
        {
            Console.CursorVisible = false;

            // gameOver는 false 상태로 구동
            gameOver = false;

            // 게임 시작 시 player 생성
            player = new Player();

            // Dictionary Instance 생성
            sceneDic = new();
            // TitleScene 추가
            sceneDic.Add("Title", new TitleScene());
            // HomeScene 추가
            sceneDic.Add("Home", new HomeScene());
            // TopFloorScene 추가
            sceneDic.Add("TopFloor", new TopFloorScene());
            // SecondFloorScene 추가
            sceneDic.Add("SecondFloor", new SecondFloorScene());
            // FirstFloorScene 추가
            sceneDic.Add("FirstFloor", new FirstFloorScene());

            // 현재 Scene을 메인 Scene으로
            curScene = sceneDic["Title"];
        }

        /// <summary>
        /// 게임 작동
        /// </summary>
        public static void Run()
        {
            // 게임오버가 아니라면 게임이 계속 돌아가게 하겠다.
            while (gameOver == false)
            {
                // 어떤 걸 돌아가게 할 것인가? 

                Console.Clear();
                curScene.Render();
                Console.WriteLine();
                curScene.Choice();
                curScene.Input();
                Console.WriteLine();
                curScene.Update();
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
            }
        }

        /// <summary>
        /// 게임 종료
        /// </summary>
        public static void End()
        {

        }

        /// <summary>
        /// sceneName을 통해 각 Scene으로 이동 구현
        /// </summary>
        /// <param name="sceneName"></param>
        public static void ChangeScene(string sceneName)
        {
            beforeScene = curScene.name;

            curScene.Exit();
            curScene = sceneDic[sceneName];
            curScene.Enter();
        }

        public static void GameOver(string reasone)
        {
            Console.WriteLine("/////..././/././/////.//...///...////");
            Console.WriteLine("..                                 //");
            Console.WriteLine("//             ㅎ...ㅎ..           ..");
            Console.WriteLine("..                                 //");
            Console.WriteLine("/..//..././/././/..///.//...///...///");
            Console.WriteLine();
            Console.WriteLine(reasone);
            gameOver = true;
        }
    }
}
