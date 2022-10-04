using BoardProject_Contracrt;
using BoardProject_CRUD;
using System;
using System.ComponentModel.Design;

namespace BoardProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string strNumber = "";
            IHomeworkBase homework = null;

            while (true)
            {
                Console.WriteLine("*********게시판 CRUD 프로그램입니다.*********");
                Console.WriteLine(" 1. 게시글 등록");
                Console.WriteLine(" 2. 게시글 목록 조회");
                Console.WriteLine(" 3. 게시글 조회");
                Console.WriteLine(" 4. 게시글 수정");
                Console.WriteLine(" 5. 게시글 삭제");
                Console.WriteLine(" 0. 종료");
                //Console.WriteLine(" *******************************************");
                Console.WriteLine("");
                Console.WriteLine(" 번호 입력 >> ");
                strNumber = Console.ReadLine();

                try
                {
                    int i = Int32.Parse(strNumber);
                    Menu menu = (Menu)i;

                    switch (menu)
                    {
                        case Menu.종료:
                            return;

                        case Menu.등록:
                            homework = new Create();
                            break;

                        case Menu.목록조회:
                            homework = new ListRead();
                            break;

                        case Menu.조회:
                            homework = new ReadSep();
                            break;

                        case Menu.수정:
                            homework = new Update();
                            break;

                        case Menu.삭제:
                            homework = new Delete();
                            break;

                        default:
                            Console.WriteLine("0부터 5까지 숫자를 입력해주세요");
                            break;

                    }

                    homework.ExcuteAll();

                }
                catch (Exception e)
                {
                    //Console.WriteLine("매개 변수가 null");
                }

            }
        }
    }
}
