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

        /// <summary>
        /// 게임 시작
        /// </summary>
        public static void Start()
        {
            // Dictionary Instance 생성
            sceneDic = new Dictionary<string, Scene>();
            // TitleScene 추가
            sceneDic.Add("Title", new TitleScene());

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
                Console.CursorVisible = false;

                Console.Clear();
                curScene.Render();
                Console.WriteLine();
                curScene.Choice();
                curScene.Input();
                Console.WriteLine();
                curScene.Result();
                Console.WriteLine();
                curScene.Wait();
                curScene.Next();
            }
        }

        /// <summary>
        /// 게임 종료
        /// </summary>
        public static void End()
        {

        }
    }
}
