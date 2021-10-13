using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_04_snake
{
    class Snake
    {
        GameObject head;
        GameObject[] body;
        int length;

        public Snake(GameObject head)
        {
            this.head = head;
            body = new GameObject[4];
            length = 0;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="direction">移动的方向</param>
        public void Move(Vector2 direction)
        {
            //蛇移动之前，记录下蛇头的位置
            Vector2 HeadPos = head.pos;
            //蛇头移动
            head.Move(direction);


            Console.SetCursorPosition(50, 1);
            Console.Write("Head: x:{0},y:{1}", head.pos.x, head.pos.y);


            Vector2 oldBodyPos;
            for (int i = 0; i < length; i++)
            {
                oldBodyPos = body[i].pos;
                body[i].pos = HeadPos;
                //
                HeadPos = oldBodyPos;

            }
        }



        public void Remove()
        {
            head.Remove();
            for (int i = 0; i < length; i++)
            {
                body[i].Remove();
            }
        }


        public void Draw()
        {
            head.Draw();
            for (int i = 0; i < length; i++)
            {
                body[i].Draw();
            } 
        }

        /// <summary>
        /// 吃到食物长身体
        /// </summary>
        public void GrowBody()
        {

            if (length == 0)
            {
                GameObject body0 = new GameObject("■", head.color, head.pos);
                body[length] = body0;
                length++;
            }
            else
            {
                GameObject lastBody = body[length - 1];
                GameObject newBody = new GameObject(lastBody.icon, lastBody.color, lastBody.pos);
                if (length >= body.Length)
                {
                    Expand();
                }
                body[length] = newBody;
                length++;
            }
        }

        /// <summary>
        /// 扩展body的长度
        /// </summary>
        private void Expand()
        {
            GameObject[] newBodys = new GameObject[body.Length * 2];
            for (int i = 0; i < length; i++)
            {
                newBodys[i] = body[i];
            }
            body = newBodys;
        }


        public static bool isDead = false;

        /// <summary>
        /// 蛇触发的事件
        /// </summary>
        /// <param name="map"></param>
        public void TriggerEvent(Map map)
        {
            if (map.FoodPos == head.pos ||
                ((head.pos.x - map.FoodPos.x == 1 || head.pos.x - map.FoodPos.x == -1)
                       && head.pos.y == map.FoodPos.y))
            {
                //说明吃到食物，要长身体;长完身体要把身体重新画出来
                //吃完食物，要重新生成食物；
                GrowBody();
                map.CreateFood();
            }

            if (head.IsDead)
            {
                isDead = true;
                Console.SetCursorPosition(10, 10);
                Console.Write("Game Over!");
            }
        }

    }
}
