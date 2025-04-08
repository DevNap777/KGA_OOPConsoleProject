using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KGA_OOPConsoleProject
{
    /// <summary>
    /// 게임의 모든 Scene들을 담고 있을 부모 클래스
    /// 추상 클래스로 설정 후 자식 클래스에서 받은 예정
    /// </summary>
    public abstract class Scene
    {
        /// <summary>
        /// 자식 클래스에서만 사용할 수 있도록 protected 설정
        /// </summary>
        protected ConsoleKey input;

        /// <summary>
        /// 상황 설명
        /// </summary>
        public abstract void Render();


        /// <summary>
        /// 선택지 제시
        /// </summary>
        public abstract void Choice();


        /// <summary>
        /// 선택지 입력 대기. Input은 모든 Scene에서 사용하기 때문에 부모 클래스에서 구현
        /// </summary>
        public void Input()
        {
            // 내가 누른 키를 보이지 않도록 true 설정
            input = Console.ReadKey(true).Key;
        }


        /// <summary>
        /// 선택에 따른 결과 출력
        /// </summary>
        public abstract void Result();


        /// <summary>
        /// 다음 Scene으로 넘어가기 위한 입력 대기
        /// </summary>
        public abstract void Wait();


        /// <summary>
        /// 다음 Scene으로 전환
        /// </summary>
        public abstract void Next();

    }
}
