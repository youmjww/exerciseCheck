/********************************************************************************************************************
 *                                                                                                                  *
 *                                                                                                                  *
 *                                                                                                                  *
 *                                     課題提出状況チェックアプリ                                                   *
 *                                     初期製作者:B4234 大村　雄哉                                                  *
 *                                     バージョン:1.1                                                               *
 *                                     this Program is open sorce                                                   *
 *                                     Welcom hack!!                          
 *                                                                                                                  *
 * ******************************************************************************************************************/





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace exerciseCheck
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            InitializeComponent();

            //ユーザがウインドウサイズを変更できないようにする
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            //最大化させないようにする
            this.MaximumSize = this.Size;

            tureBox.Text = "○";
            falseBox.Text = "×";

            //デバッグ用　後で消す
          /*  inputPathBox.Text = @"C:\Users\you\Desktop\大村君用";
            outPutPathBox.Text = @"C:\Users\you\Desktop";
            outPutFileNameBox.Text = @"hoge2";
            checkListPathBox.Text = @"C:\Users\you\Desktop\サンプル\サンプル\JavaEE2.csv";
        */

        }

       /*****************************************************************************************************************************
       *                                                                                                                            *
       *                                    表の処理                                                                                *
       *                                                                                                                            *
       ******************************************************************************************************************************/ 

        string inputPath = "null";
        string outputPath = "null";
        string checkList = "null";


        private void button1_Click(object sender, EventArgs e)
        {
            inputPathBox.Text = folderWindowSelect();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            outPutPathBox.Text = folderWindowSelect();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkListPathBox.Text = fileWindowSelect();
            
        }

        //実行ボタン
        private void button3_Click(object sender, EventArgs e)
        {

            List<string> checkName = new List<string>();

            //一致不一致の文字を格納
            string checkTrue = tureBox.Text;
            string checkFalse = falseBox.Text;

            //出力ファイルの名前
            string outputFileName = outPutFileNameBox.Text;

            //指定したディレクトリのパスを格納
            inputPath = inputPathBox.Text;
            outputPath = outPutPathBox.Text;
            checkList = checkListPathBox.Text;


            //どれか一つでも必須項目に情報が入っていなかったら処理を抜ける
            if (inputPath == "" || inputPath == "パスを指定してください" || outputPath == "" || outputPath == "パスを指定してください"
                || checkList == "" || checkList == "パスを指定してください" || outputFileName == "")
            {
                MessageBox.Show("必要な項目が入力されていません", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // StreamReader の新しいインスタンスを生成する
            System.IO.StreamReader cReader = new System.IO.StreamReader(checkList, System.Text.Encoding.Default);

            // 読み込んだ結果をすべて格納するための変数を宣言し、空の状態にする
            //string stResult = string.Empty;


            // listに読み込んだデータを入れ、読み込みできる文字がなくなるまで繰り返す
            for (int i = 0; cReader.Peek() >= 0; i++)
            {
                // ファイルを 1 行ずつ読み込む
                checkName.Insert(i, cReader.ReadLine());

                //デバッグ用　後で消すか殺す
                //Console.Out.WriteLine("hoge ");

            }
            // cReader を閉じる 
            cReader.Close();

            //文字列内に","が含まれていたら削除
            if( checkName.Count > 2 )
            {
                string[] buffer = checkName.ToArray();
                for ( int i = 0; i < checkName.Count; i++ )
                {
                    //文字列内に","が含まれていたら削除
                    buffer[i] = buffer[i].Replace(",", "");
                }

                checkName.Clear();

                for (int i = 0; i < buffer.Length; i++ )
                {
                    checkName.Add( buffer[i] );
                }
            }

            //１行で書かれている時の対策
            if (checkName.Count == 1)
            {
                string checkBuffer = checkName[0];
                
                string[] buffer = checkBuffer.Split( ',' );

                checkName.Clear();
                checkName.AddRange(buffer);
                 
            }

            //チェック用のファイル名の得とく
            string checkFileName = Path.GetFileName(checkList);
            string after = checkList.Replace(checkFileName, "");

            //ヘッダを作成
            string checkHeder = "";
            string[] checkHairetu = new string[checkName.Count];
            for (int i = 0; i < checkName.Count; i++)
            {
                checkHeder = checkHeder + "," + checkName[i];
                checkHairetu[i] = checkName[i];
            }


            //csvファイルを生成
            csvHeader(after, checkFileName);

            //指定されたディレクトリの一覧を得とく(サブディレクトリは含まない)
            string[] files = System.IO.Directory.GetDirectories(inputPath, "*", System.IO.SearchOption.TopDirectoryOnly);

            name[] uN = new name[files.Length];
            //インスタンスを一気に生成
            for (int i = 0; i < files.Length; i++)
            {
                uN[i] = new name();
            }

            //指定されたディレクトリ内のすべてのファイルをえとく
            for (int i = 0; i < files.Length; i++)
            {
                uN[i].userName(files[i]);
            }


            //入力元のフォルダー名を得とく
            //string current = Path.GetFileName(inputPath);

            StreamWriter sw = null;
            try
            {
                //ファイルの書き出し開始!!
                sw = new StreamWriter(outputPath + @".\" + outputFileName + ".csv", false, Encoding.GetEncoding(932));
                //まずチェックリスト用のリストを書き出す(ヘッダの書き出し)
                sw.WriteLine(checkHeder + ",unknown file");

                for (int i = 0; i < files.Length; i++)
                {
                    string file1 = Path.GetFileName(files[i]) + ",";
                    string hyouka = checkKadai(uN[i].getId, checkHairetu, checkTrue, checkFalse);
                    string s2 = string.Join(",\n", file1) + hyouka; //なんか、改行コードを入れるとエクセルで読み込んだ時にちゃんと改行できるみたい・・・だがCSVファイルには書かれていないし見えない・・・なぜだ・・・
                    sw.WriteLine(s2);
                }

                MessageBox.Show("処理が終了しました");
            }
            catch (System.IO.IOException en)
            {
                MessageBox.Show("対象のCSVファイルが開かれているようです\nCSVファイルを閉じてから実行しなおしてください", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sw != null)
                {
                    sw.Close();
                }
            }



            //csvを一度読みソート
            //csvSort( outputPath + @"\" , current + ".csv" );

        }





        /*****************************************************************************************************************************
        *                                                                                                                            *
        *                                    裏の処理                                                                                *
        *                                                                                                                            *
        ******************************************************************************************************************************/ 

        //フォルダパスをGUIで選択できるようにする
        private string folderWindowSelect()
        {
            //FolderBrowserDialogクラスのインスタンスを作成
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //上部に表示する説明テキストを指定する
            fbd.Description = "フォルダを指定してください。";
            //ルートフォルダを指定する
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            //最初に選択するフォルダを指定する
            fbd.SelectedPath = @"C:\Windows";
            //ユーザーが新しいフォルダを作成できるようにする
            fbd.ShowNewFolderButton = true;

            //テキストボックスにパスを入れる
            if (fbd.ShowDialog(this) == DialogResult.OK)
            {
                //選択されたフォルダを表示する
                return fbd.SelectedPath;
            }

            return "パスを指定してください";
        }

        //ファイルパスをGUIで選択できるようにする
        private string fileWindowSelect()
        {
            //OpenFileDialogクラスのインスタンスを作成
            OpenFileDialog ofd = new OpenFileDialog();

            //はじめのファイル名を指定する
            //はじめに「ファイル名」で表示される文字列を指定する
            ofd.FileName = "default.html";
            //はじめに表示されるフォルダを指定する
            //指定しない（空の文字列）の時は、現在のディレクトリが表示される
            ofd.InitialDirectory = @"C:\";
            //[ファイルの種類]に表示される選択肢を指定する
            //指定しないとすべてのファイルが表示される
            ofd.Filter = "すべてのファイル(*.*)|*.*";
            //[ファイルの種類]ではじめに選択されるものを指定する
            //2番目の「すべてのファイル」が選択されているようにする
            ofd.FilterIndex = 2;
            //タイトルを設定する
            ofd.Title = "開くファイルを選択してください";
            //ダイアログボックスを閉じる前に現在のディレクトリを復元するようにする
            ofd.RestoreDirectory = true;
            //存在しないファイルの名前が指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckFileExists = true;
            //存在しないパスが指定されたとき警告を表示する
            //デフォルトでTrueなので指定する必要はない
            ofd.CheckPathExists = true;

            //ダイアログを表示する
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                //OKボタンがクリックされたとき、選択されたファイル名を表示する
                Console.WriteLine(ofd.FileName);
                return ofd.FileName;
            }

            return "ファイルを選択してください";
        }

        //Csvを読み込んでソートしてＣＳＶに書き込み　ついでにファイル名のチェック
        private void csvSort( string csvPath, string fileName )
        {
            Csv csvRead = new Csv();
            csvWrite cw = new csvWrite();

            DataTable sorce = csvRead.CsvReader(csvPath, fileName);
            DataTable sortData = Sort(sorce);

           // DataTable judge = csvSearchAndJudge(sortData);    //デバッグ用　後で消す

            

            //CSVに書き込み
            cw.ConvertDataTableToCsv(sortData, csvPath + fileName, true);

        }

        //dbをソート
        private DataTable Sort(DataTable dt)
        {
            // Fromを昇順に並び替えます
            DataRow[] rows = (               
                from dataSort in dt.AsEnumerable()
                let date = dataSort.Field<string>("date")
                orderby date
                select dataSort
            ).ToArray();

            // 並び替えた結果を格納します
            DataTable SortTBL = rows.CopyToDataTable();
            Console.Out.WriteLine( SortTBL );
            return SortTBL;
        }

        //CSVヘッダの作成
        private DataTable csvHeader( string csvPath, string fileName )
        {
            Csv csvRead = new Csv();
            csvWrite cw = new csvWrite();

            DataTable Header = csvRead.CsvReader(csvPath, fileName);

            return Header;
        }

        /// <summary>
        /// 課題のチェックリストと課題を比較し、要らないファイルを弾いて不明なファイルをカウントアップします
        /// </summary>
        /// <param name="kadaiFile">生徒のファイル（チェックされる側）</param>
        /// <param name="checkFile">先生用ファイル（チェックする側）</param>
        /// <returns>チェックした結果(レコード的なの)が帰ってきます</returns>
        private string checkKadai( string[] kadaiFile, string[] checkFile, string checkTrue, string checkFalse )
        {
            System.Globalization.CompareInfo ci = System.Globalization.CultureInfo.CurrentCulture.CompareInfo;

            string[] kadaiBuffer = new string[ kadaiFile.Length ];
            string resurt = "";

            //ダミーデータを入れておく(何故かnullだと例外がでるんだよ・・・)
            for (int i = 0; i < kadaiFile.Length; i++) { kadaiBuffer[i] = "dummy"; }

            //.classと.htmlと.htmファイルは弾く
            int fileCounter = 0;
            for (int i = 0; i < kadaiFile.Length; i++ ) 
            {
                if( kadaiFile[i].IndexOf( ".class" ) == -1
                    && kadaiFile[i].IndexOf(".html") == -1
                    && kadaiFile[i].IndexOf(".htm") == -1)
                {
                    kadaiBuffer[fileCounter] = kadaiFile[i];
                    fileCounter++;
                }
             }

            //チェック開始!!
            int unKnownFile = 0;
            int trueCounter = 0;
            for (int i = 0; i < checkFile.Length; i++ )
            {
                //小文字に変換
                string file1 = checkFile[i].ToLower();
                for (int j = 0; j < kadaiBuffer.Length; j++) 
                {
                    //ファイル名を取得
                    string fileName = Path.GetFileName( kadaiBuffer[j] ).ToLower();

                    if ( ( ci.Compare( fileName, file1, System.Globalization.CompareOptions.IgnoreWidth) == 0 ))
                    {
                        resurt = resurt + checkTrue + ",";
                        trueCounter++;
                        break;
                    }

                    if( j == kadaiFile.Length -1 )
                    {
                        resurt = resurt + checkFalse + ",";
                    }
                }
            }

            unKnownFile = fileCounter - trueCounter;
            resurt = resurt + unKnownFile.ToString();
            return resurt;
        }
    }
}





//処理済みToDo
/*
 * ToDo: 課題を出してたら○もしくは選択したtrue　名前が違えば☓もしくは選択したfalse
 * ToDo: unKnowFileをcountUpして最後のフィールドに差し込む
 * ToDo: ファイルを開いたまま実行するとエラー表示を出して例外で落ちなくする
 * ToDo: reedmeを作って１つの課題が全員出ていなかったら先生の誤字を確認してもらうことを書く
 * 
 * ToDo: 起動中に別のクラスの課題をチェックかけようとすると結果が２重に表示されるバグを治す（多分チェックリストのメモリの開放が行えていないと思われる）。
 * ToDo: チェックリストの中に重複項目が含まれてると例外落ちするバグをどうにかする
 * ToDo: １行で書かれている場合の対策
 * ToDo: チェックリストが横に並べられてたらうまいこと読み込めなくなるバグを治す
 * 
*/

//未処理ToDo
/*
 * ToDo: 前回の設定を残しておいて次回起動時前回の設定を読み出す(XMLに書き出して起動時に読み込みと終了時に書き込みを行う)
 * 
*/

//気がついた運用注意（reedme用）
/*
 * 
 * 機種依存文字は使わない　特に、一致不一致のところ！
 * チェックリストは１列か１行にまとめる
 * 制作環境
 * .NetFrameworkは知らんｗなんぼだろ・・・ｗ
 * ついでにたまたま見つけた機能　空のCSVファイルをチェックリストに指定するとファイルの提出数をカウントできることを書く
 * 
 * 
 */
