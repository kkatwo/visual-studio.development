using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Probability_verification
{
    /// <summary>
    /// メインウィンドウ
    /// </summary>
    public partial class MainWindow : Form
    {
        /// <summary>
        /// アイテムデータ
        /// </summary>
        public class ItemData
        {
            public string Type { get; set; }

            /// <summary>
            /// コンストラクタ
            /// </summary>
            /// <param name="type"></param>
            public ItemData(string type)
            {
                Type = type;
            }
        }

        private const string ITEMTYPE_OTHER = "other";
        private const string ITEMTYPE_TARGET = "target";
        private const string ITEMTYPE_RESET = "reset";
        private Random rnd = new Random();


        private List<ItemData> restItems = new List<ItemData>();
        private Dictionary<string,int> getItems = new Dictionary<string, int>();

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        private void UpdateHalfResetThresholdEnabled()
        {
            halfResetThreshold.Enabled = halfResetCheck.Checked;
        }

        /// <summary>
        /// アイテムデータのリセット
        /// </summary>
        private void ResetItemData()
        {
            restItems.Clear();

            //  リセット可能アイテム
            restItems.Add(new ItemData(ITEMTYPE_RESET));
            //  目的アイテム
            restItems.Add(new ItemData(ITEMTYPE_TARGET));
            restItems.Add(new ItemData(ITEMTYPE_TARGET));
            //  埋める
            while( restItems.Count < 100 ) {
                restItems.Add(new ItemData(ITEMTYPE_OTHER));
            }
        }
        /// <summary>
        /// リセット対象アイテム取得済みか
        /// </summary>
        /// <returns></returns>
        private bool IsGotResetItem()
        {
            foreach( ItemData item in restItems)
            {
                if (item.Type == ITEMTYPE_RESET)
                {
                    return false;
                }
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private int RestTargetItemCount()
        {
            int count = 0;
            foreach (ItemData item in restItems)
            {
                if (item.Type == ITEMTYPE_TARGET)
                {
                    count++;
                }
            }
            return count;
        }
        /// <summary>
        /// 実効ボタンクリック
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void executeButton_Click(object sender, EventArgs e)
        {
            try
            {
                executeButton.Enabled = false;

                //  入手済みアイテムのリセット
                getItems.Clear();

                for (int i = 0; i < (int)setCount.Value; i++)
                {
                    ExecuteOneSet();
                }

                //  平均化
                Dictionary<string, double> result = new Dictionary<string, double>();
                foreach (KeyValuePair<string, int> pair in getItems)
                {
                    //  平均化
                    result[pair.Key] = (double)getItems[pair.Key] / (int)setCount.Value;
                    //  確率化
                    result[pair.Key] = result[pair.Key] / (int)crystalCount.Value * 100;
                }

                //  書き出し
                string resultText = "---- " + DateTime.Now + " ----" + Environment.NewLine;
                resultText += "無条件残閾値:" + resetThreshold.Value  + Environment.NewLine;
                if (halfResetCheck.Checked)
                {
                    resultText += "中間残閾値:" + halfResetThreshold.Value + Environment.NewLine;
                }
                foreach (KeyValuePair<string, double> pair in result)
                {
                    resultText += pair.Key + " : " + pair.Value + "%" + Environment.NewLine;
                }
                resultTextBox.Text = resultText + resultTextBox.Text;

            }
            catch (Exception ex)
            {
            }
            finally
            {
                executeButton.Enabled = true;
            }
        }

        private void ExecuteOneSet()
        {

            //  最初のデータリセット
            ResetItemData();

            for (int i = 0; i < (int)crystalCount.Value; i++)
            {
                bool isReset = false;
                int itemNum = rnd.Next() % restItems.Count;
                string type = restItems[itemNum].Type;
                restItems.RemoveAt(itemNum);

                try
                {
                    getItems[type] = getItems[type] + 1;
                }
                catch (KeyNotFoundException ex)
                {
                    getItems[type] = 1;
                }
                         
                //  アイテム切れでリセット
                if (restItems.Count <= 0)
                {
                    isReset = true;
                }

                //  目的達成でリセット
                if (RestTargetItemCount() == 0)
                {
                    isReset = true;
                }

                //  目的アイテムちょっと取得済み
                if (halfResetCheck.Checked)
                {
                    //  1個取得済みで残りアイテム数が一定以上の場合はリセット
                    if (RestTargetItemCount() == 1 &&
                        (int)halfResetThreshold.Value < restItems.Count)
                    {
                        isReset = true;
                    }
                }

                //  閾値超える
                if ( restItems.Count <= (int)resetThreshold.Value )
                {
                    isReset = true;
                }

                //  アイテムのリセット
                if( isReset && IsGotResetItem() )
                {
                    ResetItemData();
                }
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            UpdateHalfResetThresholdEnabled();
        }

        private void halfResetCheck_CheckedChanged(object sender, EventArgs e)
        {
            UpdateHalfResetThresholdEnabled();
        }
    }
}
