﻿using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FineUIMvc.Examples.Areas.Form.Controllers
{
    public class CheckBoxListUpdateController : FineUIMvc.Examples.Controllers.BaseController
    {
        // GET: Form/CheckBoxListUpdate
        public ActionResult Index()
        {
            LoadData();

            return View();
        }

        // 准备 CheckBoxList2 用到的数据
        private void LoadData()
        {
            List<TestClass> myList = new List<TestClass>();
            myList.Add(new TestClass("value1", "可选项 1"));
            myList.Add(new TestClass("value2", "可选项 2"));
            myList.Add(new TestClass("value3", "可选项 3"));
            myList.Add(new TestClass("value4", "可选项 4"));
            myList.Add(new TestClass("value5", "可选项 5"));
            myList.Add(new TestClass("value6", "可选项 6"));

            ViewBag.CheckBoxList2DataSource = myList;
            ViewBag.CheckBoxList2SelectedValueArray = new string[] { "value1", "value2", "value3" };
        }

        #region TestClass

        public class TestClass
        {
            private string _id;

            public string Id
            {
                get { return _id; }
                set { _id = value; }
            }
            private string _name;

            public string Name
            {
                get { return _name; }
                set { _name = value; }
            }

            public TestClass(string id, string name)
            {
                _id = id;
                _name = name;
            }

        }


        #endregion

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult btnCheckedItemsList_Click(string name, string selected)
        {
            ShowNotify(String.Format(name + "选中项的值：{0}", selected));

            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult btnUpdateList1_Click()
        {
            var CheckBoxList1 = UIHelper.CheckBoxList("CheckBoxList1");

            List<TestClass> myList = new List<TestClass>();
            myList.Add(new TestClass("value1", "数据绑定值 1"));
            myList.Add(new TestClass("value2", "数据绑定值 2"));
            myList.Add(new TestClass("value3", "数据绑定值 3"));
            myList.Add(new TestClass("value4", "数据绑定值 4"));

            // 更新数据源，然后设置选项
            CheckBoxList1.DataSource(myList, "Id", "Name");
            CheckBoxList1.SelectedValueArray(new string[] { "value1", "value3" });

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult btnUpdateList2_Click()
        {
            var CheckBoxList2 = UIHelper.CheckBoxList("CheckBoxList2");

            List<TestClass> myList = new List<TestClass>();
            myList.Add(new TestClass("value1", "数据绑定值 1"));
            myList.Add(new TestClass("value2", "数据绑定值 2"));
            myList.Add(new TestClass("value3", "数据绑定值 3"));
            myList.Add(new TestClass("value4", "数据绑定值 4"));
            myList.Add(new TestClass("value5", "数据绑定值 5"));
            myList.Add(new TestClass("value6", "数据绑定值 6"));

            // 更新数据源，然后设置选项
            CheckBoxList2.DataSource(myList, "Id", "Name");
            CheckBoxList2.SelectedValueArray(new string[] { "value1", "value3", "value6" });
            
            return UIHelper.Result();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult btnUpdateList4_Click(int count)
        {
            var CheckBoxList4 = UIHelper.CheckBoxList("CheckBoxList4");

            if (count > 0)
            {
                CheckBoxList4.DataSource(null);
            }
            else
            {
                List<TestClass> myList = new List<TestClass>();
                myList.Add(new TestClass("value1", "数据绑定值 1"));
                myList.Add(new TestClass("value2", "数据绑定值 2"));
                myList.Add(new TestClass("value3", "数据绑定值 3"));
                myList.Add(new TestClass("value4", "数据绑定值 4"));
                myList.Add(new TestClass("value5", "数据绑定值 5"));
                myList.Add(new TestClass("value6", "数据绑定值 6"));

                // 更新数据源，然后设置选项
                CheckBoxList4.DataSource(myList, "Id", "Name");
                CheckBoxList4.SelectedValueArray(new string[] { "value1", "value2" });
            }

            return UIHelper.Result();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult btnUpdateList3_Click()
        {
            var CheckBoxList3 = UIHelper.CheckBoxList("CheckBoxList3");

            List<TestClass> myList = new List<TestClass>();
            myList.Add(new TestClass("value1", "数据绑定值 1"));
            myList.Add(new TestClass("value2", "数据绑定值 2"));
            myList.Add(new TestClass("value3", "数据绑定值 3"));
            myList.Add(new TestClass("value4", "数据绑定值 4"));
            myList.Add(new TestClass("value5", "数据绑定值 5"));
            myList.Add(new TestClass("value6", "数据绑定值 6"));
            myList.Add(new TestClass("value7", "数据绑定值 7"));
            myList.Add(new TestClass("value8", "数据绑定值 8"));
            myList.Add(new TestClass("value9", "数据绑定值 9"));

            // 更新数据源，然后设置选项
            CheckBoxList3.DataSource(myList, "Id", "Name");
            CheckBoxList3.SelectedValueArray(new string[] { "value1", "value2", "value6", "value7" });

            return UIHelper.Result();
        }
    }
}