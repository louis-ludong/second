using System;
using System.Collections.Generic;
using System.Text;
using IGT.Service.PLC;
using System.Linq;
namespace IGT.Service.Storage
{
    /// <summary>
    /// 修正设定
    /// </summary>
    public class CorrectionSetting : IStorageModel<Models.Settings.CorrectSetting>
    {
        internal void UpdateGasPress(Models.Settings.PressCorrectionSet model)
        {
            this.GasPress.Items.AttactNoEvent(model.Items);
            this.GasPress.Corrections.AttactNoEvent(model.Corrections);
        }
        /// <summary>
        /// 实例化
        /// </summary>
        /// <param name="model">修正设定</param>
        public CorrectionSetting(Models.Settings.CorrectSetting model)
        {
            this.Red = new NotityTempCorrectionSet(new NotityArray<sbyte>(model.RedTemp.Items, "Red.Temps")
                , new NotityArray<int>(model.RedTemp.Corrections, "Red.Corrections"));
            this.Gas = new NotityTempCorrectionSet(new NotityArray<sbyte>(model.GasTemp.Items, "Gas.Temps")
                , new NotityArray<int>(model.GasTemp.Corrections, "Gas.Corrections"));
            this.GasPress = new NotityPressCorrectionSet(new NotityArray<float>(model.GasPress.Items, "GasPress.Items")
                , new NotityArray<float>(model.GasPress.Corrections, "GasPress.Corrections"));//LDC int...float
            this.Red.Temps.ItemChangedCustomSender += ItemChanged;
            this.Red.Corrections.ItemChangedCustomSender += ItemChanged;
            this.Gas.Temps.ItemChangedCustomSender += ItemChanged;
            this.Gas.Corrections.ItemChangedCustomSender += ItemChanged;
            this.GasPress.Items.ItemChangedCustomSender += ItemChanged;
            this.GasPress.Corrections.ItemChangedCustomSender += ItemChanged;
            
        }

        void ItemChanged(object sender, ItemChangedEventArgs e)
        {
            TryAddChanged(sender.ToString(), e.ItemIndex);
        }
        #region IStorageModel<Models.Settings.CorrectSetting> 成员
        public void CancelChanges()
        {
            ChangedCollection.Clear();
        }
        public Models.Settings.CorrectSetting Detaching()
        {
            var model = new Models.Settings.CorrectSetting();
            model.RedTemp = new Models.Settings.TempCorrectionSet();
            model.RedTemp.Items = this.Red.Temps.ToArray();
            model.RedTemp.Corrections = this.Red.Corrections.ToArray();
            model.GasTemp = new Models.Settings.TempCorrectionSet();
            model.GasTemp.Items = this.Gas.Temps.ToArray();
            model.GasTemp.Corrections = this.Gas.Corrections.ToArray();
            model.GasPress = new Models.Settings.PressCorrectionSet();
            model.GasPress.Items = this.GasPress.Items.ToArray();
            model.GasPress.Corrections = this.GasPress.Corrections.ToArray();
            return model;
        }

        #endregion

        #region IStorageModel 成员
        public void Attach(Models.Settings.CorrectSetting model)
        {
            for (int i = 0; i < this.Red.Temps.Count; i++)
                this.Red.Temps[i] = model.RedTemp.Items[i];
            for (int i = 0; i < this.Red.Corrections.Count; i++)
                this.Red.Corrections[i] = model.RedTemp.Corrections[i];

            for (int i = 0; i < this.Gas.Temps.Count; i++)
                this.Gas.Temps[i] = model.GasTemp.Items[i];
            for (int i = 0; i < this.Gas.Corrections.Count; i++)
                this.Gas.Corrections[i] = model.GasTemp.Corrections[i];

            for (int i = 0; i < this.GasPress.Items.Count; i++)
                this.GasPress.Items[i] = model.GasPress.Items[i];
            for (int i = 0; i < this.GasPress.Corrections.Count; i++)
                this.GasPress.Corrections[i] = model.GasPress.Corrections[i];
        }
        public void SaveChanges(SerialPortsUtils.Agents.Agent io)
        {

            foreach (var item in ChangedCollection)
            {
                switch (item.Key)
                {
                    case "Red.Temps":
                        foreach (var index in item.Value)
                        {
                            io.SendAndRead(InstructionSet.SetRedTempCorrectionPart1, InstructionSet.SetRedTempCorrectionPart2_Temp[index]
                                , new byte[] { ValueConvert.SingleTempValue(this.Red.Temps[index]) });
                        }
                        break;
                    case "Red.Corrections":
                        foreach (var index in item.Value)
                        {
                            io.SendAndRead(InstructionSet.SetRedTempCorrectionPart1, InstructionSet.SetRedTempCorrectionPart2_Correction[index]
                                , new byte[] { ValueConvert.TempCorrectionValue(this.Red.Corrections[index]) });
                        }
                        break;
                    case "Gas.Temps":
                        foreach (var index in item.Value)
                        {
                            io.SendAndRead(InstructionSet.SetGasTempCorrectionPart1, InstructionSet.SetGasTempCorrectionPart2_Temp[index]
                                , new byte[] { ValueConvert.SingleTempValue(this.Gas.Temps[index]) });
                        }
                        break;
                    case "Gas.Corrections":
                        foreach (var index in item.Value)
                        {
                            io.SendAndRead(InstructionSet.SetGasTempCorrectionPart1, InstructionSet.SetGasTempCorrectionPart2_Correction[index]
                                , new byte[] { ValueConvert.TempCorrectionValue(this.Gas.Corrections[index]) });
                        }
                        break;
                    case "GasPress.Items":
                        foreach (var index in item.Value)
                        {
                            io.SendAndRead(InstructionSet.SetGasPressPart1, InstructionSet.SetGasPressPart2_Items[index]
                                ,  ValueConvert.PressValue(this.GasPress.Items[index]));
                        }
                        break;
                    case "GasPress.Corrections":
                        foreach (var index in item.Value)
                        {
                            io.SendAndRead(InstructionSet.SetGasPressPart1, InstructionSet.SetGasPressPart2_Correction[index]
                                , ValueConvert.PressCorrectionValue(this.GasPress.Corrections[index]));
                        }
                        break;
                }
                item.Value.Clear();
            }
        }

        #endregion

        #region IDisposable 成员

        public void Dispose()
        {
            this.Red.Temps.ItemChangedCustomSender -= ItemChanged;
            this.Red.Corrections.ItemChangedCustomSender -= ItemChanged;
            this.Gas.Temps.ItemChangedCustomSender -= ItemChanged;
            this.Gas.Corrections.ItemChangedCustomSender -= ItemChanged;
            this.ChangedCollection.Clear();
        }

        #endregion
        /// <summary>
        /// 减压器温度修正
        /// </summary>
        public NotityTempCorrectionSet Red { get;private set; }
        /// <summary>
        /// 燃气温度修正
        /// </summary>
        public NotityTempCorrectionSet Gas { get; private set; }
        /// <summary>
        /// 燃气压力修正
        /// </summary>
        public NotityPressCorrectionSet GasPress { get; private set; }
        Dictionary<String, List<int>> ChangedCollection = new Dictionary<string, List<int>>();
        private void TryAddChanged(String key, int index)
        {
            if (ChangedCollection.ContainsKey(key))
            {
                if (!ChangedCollection[key].Contains(index))
                    ChangedCollection[key].Add(index);
            }
            else
            {
                var list = new List<int>(); list.Add(index);
                ChangedCollection.Add(key, list);
            }
        }
        public class NotityTempCorrectionSet
        {
            public NotityTempCorrectionSet(NotityArray<sbyte> temps,NotityArray<int> corrections)
            {
                this.Temps = temps;
                this.Corrections = corrections;
            }
            public NotityArray<sbyte> Temps { get;protected set; }
            public NotityArray<int> Corrections { get;protected set; }

            public int Over { get { return Corrections[Corrections.Count - 1]; } }
        }
        public class NotityPressCorrectionSet
        {
            public NotityPressCorrectionSet(NotityArray<float> items, NotityArray<float> corrections)//LDC int....float
            {
                this.Items = items;
                this.Corrections = corrections;
            }
            public NotityArray<float> Items { get; protected set; } // protected set--------set
            public NotityArray<float> Corrections { get; protected set; }//LDC int...float      protected set--------set
        }
    }
}
