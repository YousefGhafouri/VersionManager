using Janus.Windows.GridEX;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using VisualStyle = Janus.Windows.GridEX.VisualStyle;

namespace VersionManager.Utilities
{
    public partial class BAGrid : GridEX
    {
        #region Private Peroperties

        bool checkRestrictionDataType;

        #endregion

        #region Properties
        public List<string> DataTypeRestrictionColumns { get; set; }
        public bool CheckRestrictionDataType
        {
            get { return checkRestrictionDataType; }
            set
            {
                checkRestrictionDataType = value;
            }
        }

        #endregion

        #region Public Method

        public BAGrid()
        {
            VisualStyle = VisualStyle.Office2010;
        }
        public T GetRow<T>() where T : new()
        {
            const BindingFlags flags = BindingFlags.SetField | BindingFlags.SetProperty | BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;

            var objFieldNames = (from PropertyInfo aProp in typeof(T).GetProperties(flags)
                                 select aProp.Name);

            var gridColumns = (from GridEXColumn column in RootTable.Columns
                               select column.DataMember);

            var commonFields = objFieldNames.Intersect(gridColumns, StringComparer.OrdinalIgnoreCase).ToList();

            var dataRow = GetRow();
            var aTSource = new T();
            foreach (var column in commonFields)
            {
                var value = dataRow.Cells[column].Value;

                if (value == null || value == DBNull.Value)
                    continue;
                PropertyInfo propertyInfos = aTSource.GetType().GetProperty(column);//, BindingFlags.IgnoreCase
                                                                                    //| BindingFlags.Public
                                                                                    //| BindingFlags.Instance);
                //if (propertyInfos.SetMethod == null)
                //    continue;
                propertyInfos.SetValue(aTSource, value, null);
            }
            return aTSource;
        }
        public IEnumerable<T> GetRows<T>() where T : new()
        {
            const BindingFlags flags = BindingFlags.SetField | BindingFlags.SetProperty | BindingFlags.Public | BindingFlags.Instance | BindingFlags.NonPublic;
            var objFieldNames = (from PropertyInfo aProp in typeof(T).GetProperties(flags)
                                 select aProp.Name);
            var gridColumns = (from GridEXColumn column in RootTable.Columns
                               select column.DataMember);
            var commonFields = objFieldNames.Intersect(gridColumns, StringComparer.OrdinalIgnoreCase).ToList();

            foreach (GridEXRow dataRow in GetCheckedRows())
            {
                var aTSource = new T();
                foreach (var column in commonFields)
                {
                    var value = dataRow.Cells[column].Value;

                    if (value == null || value == DBNull.Value)
                        continue;

                    PropertyInfo propertyInfos = aTSource.GetType().GetProperty(column);//, BindingFlags.IgnoreCase
                                                                                        //| BindingFlags.Public
                                                                                        //| BindingFlags.Instance);

                    //if (propertyInfos.SetMethod == null)
                    //    continue;

                    propertyInfos.SetValue(aTSource, value, null);
                }
                yield return aTSource;
            }
        }
        public void FillValueList<T>(string columnName, Func<T, bool> filter = null) where T : Enum
        {
            if (string.IsNullOrEmpty(columnName))
                throw new ArgumentNullException(nameof(columnName));

            this.RootTable.Columns[columnName].HasValueList = true;
            this.RootTable.Columns[columnName].ValueList.Clear();
            if (filter != null)
                foreach (var item in EnumExtensions.EnumToList<T>().Where(w => filter((T)w.Value)))
                {
                    this.RootTable.Columns[columnName].ValueList.Add(item.Value, item.Caption);
                }
            else
                foreach (var item in EnumExtensions.EnumToList<T>())
                {
                    this.RootTable.Columns[columnName].ValueList.Add(item.Value, item.Caption);
                }

        }
        

        #endregion

        #region Private Method

        private void HandleColumnDataTypeRestriction(KeyPressEventArgs key)
        {
            var gridEXRow = this.GetRow();
            if (gridEXRow == null || gridEXRow.RowType != RowType.Record)
                return;

            var grid = this;
            if (grid.CurrentColumn == null)
                return;
            foreach (var columnKey in DataTypeRestrictionColumns)
            {
                if (grid.CurrentColumn.Key == columnKey)
                {
                    if (key.KeyChar == '\b')
                        return;

                   
                }
            }
        }

        #endregion

        #region Event

        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            if (checkRestrictionDataType)
                HandleColumnDataTypeRestriction(e);
            base.OnKeyPress(e);
        }

        #endregion

        //public float RowHeight { get; set; }
        //private int ColumnCount { get { return Columns.Count; } /*set{ Columns.Count = value; } */}
        //public List<Row> Rows { get; set; }
        //public List<Column> Columns { get; set; }
        //private System.Windows.Forms.TableLayoutPanel BasePanel;
        //public class Column
        //{
        //    public ColumnButtonStyle ButtonStyle { get; set; }
        //    public ColumnEditType EditType { get; set; }
        //    public int Width { get; set; }
        //    public Color BackColor { get; set; }
        //    public Color ForColor { get; set; }
        //}
        //public class Row
        //{
        //    public List<Column> Cells { get; set; }
        //}

        //private void DrawGrid()
        //{
        //    int Index = 0;
        //    BasePanel = new System.Windows.Forms.TableLayoutPanel();
        //    BasePanel.RowStyles.Add(new RowStyle(SizeType.Absolute, RowHeight));
        //    foreach (Column col in Columns)
        //    {
        //        Label _TextBox = new Label()
        //        {
        //            TextAlign = ContentAlignment.MiddleCenter,
        //            BorderStyle = BorderStyle.Fixed3D,
        //            Width = col.Width,
        //            Dock = DockStyle.Fill
        //        };

        //        BasePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, col.Width));
        //        BasePanel.SetRow(_TextBox, Index++);
        //    }
        //}

        //private void BAGrid_Paint(object sender, PaintEventArgs e)
        //{
        //    //DrawGrid();
        //}
    }
}
