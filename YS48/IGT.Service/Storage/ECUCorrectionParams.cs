using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Linq;
namespace IGT.Service.Storage
{
    /// <summary>
    /// ECU修正比例
    /// </summary>
    public class ECUCorrectionParams : IStorageModel<Models.Settings.ECUCorrectionParams>
    {
        /// <summary>
        /// 实例化 ECU修正比例
        /// </summary>
        /// <param name="model">ECU修正比例</param>
        public ECUCorrectionParams(Models.Settings.ECUCorrectionParams model)
        {
            this._CalibrationScale = model.CalibrationScale;
            this.LocationX = new NotityArray<float>(model.LocationX);
            this.LocationX.ItemChanged += CalibrationScale_ItemChanged;
        }

        void CalibrationScale_ItemChanged(object sender, ItemChangedEventArgs e)
        {
            this.LocationXChanged = true;
        }

        #region IStorageModel<ECUCorrectionParams> 成员
        public void Attach(Models.Settings.ECUCorrectionParams model)
        {
            this.CalibrationScale = model.CalibrationScale;
            for (int i = 0; i < model.LocationX.Length; i++)
            {
                this.LocationX[i] = model.LocationX[i];
            }
        }
        public Models.Settings.ECUCorrectionParams Detaching()
        {
            var model = new Models.Settings.ECUCorrectionParams();
            model.CalibrationScale = this.CalibrationScale.ToArray();
            model.LocationX = this.LocationX.ToArray();
            return model;
        }

        #endregion

        #region IStorageModel 成员
        public void CancelChanges()
        {
            CalibrationScaleChanged = false;
            LocationXChanged = false;
        }
        public void SaveChanges(SerialPortsUtils.Agents.Agent io)
        {
            System.Diagnostics.Debug.WriteLine("Begin Apply Changes On ECUCorrectionParams");
            if (CalibrationScaleChanged == true)
            {
                CalibrationScaleChanged = false;
                io.SetECUCorrectionParams_CalibrationScale(this.CalibrationScale.ToArray());
            }
            if (LocationXChanged == true)
            {
                LocationXChanged = false;
                io.SetECUCorrectionParams_LocationX(this.LocationX.ToArray());
            }
            System.Diagnostics.Debug.WriteLine("End Apply Changes On ECUCorrectionParams");
        }

        #endregion

        #region IDisposable 成员

        public void Dispose()
        {
            this.LocationX.ItemChanged -= CalibrationScale_ItemChanged;
        }

        #endregion
        bool CalibrationScaleChanged = false;
        bool LocationXChanged = false;
        #region Model属性

        private int[] _CalibrationScale;

        /// <summary>
        /// 0.0ms-25.5ms的修正比例
        /// </summary>
        public int[] CalibrationScale
        {
            get { return _CalibrationScale; }
            set {
                _CalibrationScale = value;
                CalibrationScaleChanged = true; }
        }

        /// <summary>
        /// 10个坐标点的X
        /// </summary>
        public NotityArray<Single> LocationX { get;private set; }
        #endregion

    }
}
