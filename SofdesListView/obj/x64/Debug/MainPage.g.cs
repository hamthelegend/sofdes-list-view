﻿#pragma checksum "C:\Users\hamue\source\repos\SofdesListView\SofdesListView\MainPage.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "28959D350C0691BBE6861C4EBE45CF50B02F22AF3C749826ABD4DD787FB15464"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SofdesListView
{
    partial class MainPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private static class XamlBindingSetters
        {
            public static void Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(global::Windows.UI.Xaml.Controls.ItemsControl obj, global::System.Object value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Object) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Object), targetNullValue);
                }
                obj.ItemsSource = value;
            }
            public static void Set_Microsoft_Toolkit_Uwp_UI_Controls_DataGrid_ItemsSource(global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid obj, global::System.Collections.IEnumerable value, string targetNullValue)
            {
                if (value == null && targetNullValue != null)
                {
                    value = (global::System.Collections.IEnumerable) global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(global::System.Collections.IEnumerable), targetNullValue);
                }
                obj.ItemsSource = value;
            }
        };

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        private class MainPage_obj1_Bindings :
            global::Windows.UI.Xaml.Markup.IDataTemplateComponent,
            global::Windows.UI.Xaml.Markup.IXamlBindScopeDiagnostics,
            global::Windows.UI.Xaml.Markup.IComponentConnector,
            IMainPage_Bindings
        {
            private global::SofdesListView.MainPage dataRoot;
            private bool initialized = false;
            private const int NOT_PHASED = (1 << 31);
            private const int DATA_CHANGED = (1 << 30);

            // Fields for each control that has bindings.
            private global::Windows.UI.Xaml.Controls.ListView obj2;
            private global::Windows.UI.Xaml.Controls.ListView obj3;
            private global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid obj4;
            private global::Windows.UI.Xaml.Controls.ComboBox obj11;

            // Static fields for each binding's enabled/disabled state
            private static bool isobj2ItemsSourceDisabled = false;
            private static bool isobj3ItemsSourceDisabled = false;
            private static bool isobj4ItemsSourceDisabled = false;
            private static bool isobj11ItemsSourceDisabled = false;

            private MainPage_obj1_BindingsTracking bindingsTracking;

            public MainPage_obj1_Bindings()
            {
                this.bindingsTracking = new MainPage_obj1_BindingsTracking(this);
            }

            public void Disable(int lineNumber, int columnNumber)
            {
                if (lineNumber == 47 && columnNumber == 13)
                {
                    isobj2ItemsSourceDisabled = true;
                }
                else if (lineNumber == 88 && columnNumber == 13)
                {
                    isobj3ItemsSourceDisabled = true;
                }
                else if (lineNumber == 99 && columnNumber == 13)
                {
                    isobj4ItemsSourceDisabled = true;
                }
                else if (lineNumber == 34 && columnNumber == 17)
                {
                    isobj11ItemsSourceDisabled = true;
                }
            }

            // IComponentConnector

            public void Connect(int connectionId, global::System.Object target)
            {
                switch(connectionId)
                {
                    case 2: // MainPage.xaml line 43
                        this.obj2 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 3: // MainPage.xaml line 84
                        this.obj3 = (global::Windows.UI.Xaml.Controls.ListView)target;
                        break;
                    case 4: // MainPage.xaml line 95
                        this.obj4 = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)target;
                        break;
                    case 11: // MainPage.xaml line 30
                        this.obj11 = (global::Windows.UI.Xaml.Controls.ComboBox)target;
                        break;
                    default:
                        break;
                }
            }

            // IDataTemplateComponent

            public void ProcessBindings(global::System.Object item, int itemIndex, int phase, out int nextPhase)
            {
                nextPhase = -1;
            }

            public void Recycle()
            {
                return;
            }

            // IMainPage_Bindings

            public void Initialize()
            {
                if (!this.initialized)
                {
                    this.Update();
                }
            }
            
            public void Update()
            {
                this.Update_(this.dataRoot, NOT_PHASED);
                this.initialized = true;
            }

            public void StopTracking()
            {
                this.bindingsTracking.ReleaseAllListeners();
                this.initialized = false;
            }

            public void DisconnectUnloadedObject(int connectionId)
            {
                throw new global::System.ArgumentException("No unloadable elements to disconnect.");
            }

            public bool SetDataRoot(global::System.Object newDataRoot)
            {
                this.bindingsTracking.ReleaseAllListeners();
                if (newDataRoot != null)
                {
                    this.dataRoot = (global::SofdesListView.MainPage)newDataRoot;
                    return true;
                }
                return false;
            }

            public void Loading(global::Windows.UI.Xaml.FrameworkElement src, object data)
            {
                this.Initialize();
            }

            // Update methods for each path node used in binding steps.
            private void Update_(global::SofdesListView.MainPage obj, int phase)
            {
                if (obj != null)
                {
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_SelectedCourses(obj.SelectedCourses, phase);
                        this.Update_AddedCourses(obj.AddedCourses, phase);
                    }
                    if ((phase & (NOT_PHASED | (1 << 0))) != 0)
                    {
                        this.Update_SubmittedCourses(obj.SubmittedCourses, phase);
                    }
                    if ((phase & (NOT_PHASED | DATA_CHANGED | (1 << 0))) != 0)
                    {
                        this.Update_AvailableCourses(obj.AvailableCourses, phase);
                    }
                }
            }
            private void Update_SelectedCourses(global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_SelectedCourses(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 43
                    if (!isobj2ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj2, obj, null);
                    }
                }
            }
            private void Update_AddedCourses(global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_AddedCourses(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 84
                    if (!isobj3ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj3, obj, null);
                    }
                }
            }
            private void Update_SubmittedCourses(global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj, int phase)
            {
                if ((phase & ((1 << 0) | NOT_PHASED )) != 0)
                {
                    // MainPage.xaml line 95
                    if (!isobj4ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Microsoft_Toolkit_Uwp_UI_Controls_DataGrid_ItemsSource(this.obj4, obj, null);
                    }
                }
            }
            private void Update_AvailableCourses(global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj, int phase)
            {
                this.bindingsTracking.UpdateChildListeners_AvailableCourses(obj);
                if ((phase & ((1 << 0) | NOT_PHASED | DATA_CHANGED)) != 0)
                {
                    // MainPage.xaml line 30
                    if (!isobj11ItemsSourceDisabled)
                    {
                        XamlBindingSetters.Set_Windows_UI_Xaml_Controls_ItemsControl_ItemsSource(this.obj11, obj, null);
                    }
                }
            }

            [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
            [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
            private class MainPage_obj1_BindingsTracking
            {
                private global::System.WeakReference<MainPage_obj1_Bindings> weakRefToBindingObj; 

                public MainPage_obj1_BindingsTracking(MainPage_obj1_Bindings obj)
                {
                    weakRefToBindingObj = new global::System.WeakReference<MainPage_obj1_Bindings>(obj);
                }

                public MainPage_obj1_Bindings TryGetBindingObject()
                {
                    MainPage_obj1_Bindings bindingObject = null;
                    if (weakRefToBindingObj != null)
                    {
                        weakRefToBindingObj.TryGetTarget(out bindingObject);
                        if (bindingObject == null)
                        {
                            weakRefToBindingObj = null;
                            ReleaseAllListeners();
                        }
                    }
                    return bindingObject;
                }

                public void ReleaseAllListeners()
                {
                    UpdateChildListeners_SelectedCourses(null);
                    UpdateChildListeners_AddedCourses(null);
                    UpdateChildListeners_AvailableCourses(null);
                }

                public void PropertyChanged_SelectedCourses(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_SelectedCourses(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> cache_SelectedCourses = null;
                public void UpdateChildListeners_SelectedCourses(global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj)
                {
                    if (obj != cache_SelectedCourses)
                    {
                        if (cache_SelectedCourses != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_SelectedCourses).PropertyChanged -= PropertyChanged_SelectedCourses;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_SelectedCourses).CollectionChanged -= CollectionChanged_SelectedCourses;
                            cache_SelectedCourses = null;
                        }
                        if (obj != null)
                        {
                            cache_SelectedCourses = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_SelectedCourses;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_SelectedCourses;
                        }
                    }
                }
                public void PropertyChanged_AddedCourses(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_AddedCourses(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> cache_AddedCourses = null;
                public void UpdateChildListeners_AddedCourses(global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj)
                {
                    if (obj != cache_AddedCourses)
                    {
                        if (cache_AddedCourses != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_AddedCourses).PropertyChanged -= PropertyChanged_AddedCourses;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_AddedCourses).CollectionChanged -= CollectionChanged_AddedCourses;
                            cache_AddedCourses = null;
                        }
                        if (obj != null)
                        {
                            cache_AddedCourses = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_AddedCourses;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_AddedCourses;
                        }
                    }
                }
                public void PropertyChanged_AvailableCourses(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        string propName = e.PropertyName;
                        global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course>;
                        if (global::System.String.IsNullOrEmpty(propName))
                        {
                        }
                        else
                        {
                            switch (propName)
                            {
                                default:
                                    break;
                            }
                        }
                    }
                }
                public void CollectionChanged_AvailableCourses(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
                {
                    MainPage_obj1_Bindings bindings = TryGetBindingObject();
                    if (bindings != null)
                    {
                        global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj = sender as global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course>;
                    }
                }
                private global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> cache_AvailableCourses = null;
                public void UpdateChildListeners_AvailableCourses(global::System.Collections.ObjectModel.ObservableCollection<global::SofdesListView.Course> obj)
                {
                    if (obj != cache_AvailableCourses)
                    {
                        if (cache_AvailableCourses != null)
                        {
                            ((global::System.ComponentModel.INotifyPropertyChanged)cache_AvailableCourses).PropertyChanged -= PropertyChanged_AvailableCourses;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)cache_AvailableCourses).CollectionChanged -= CollectionChanged_AvailableCourses;
                            cache_AvailableCourses = null;
                        }
                        if (obj != null)
                        {
                            cache_AvailableCourses = obj;
                            ((global::System.ComponentModel.INotifyPropertyChanged)obj).PropertyChanged += PropertyChanged_AvailableCourses;
                            ((global::System.Collections.Specialized.INotifyCollectionChanged)obj).CollectionChanged += CollectionChanged_AvailableCourses;
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 2: // MainPage.xaml line 43
                {
                    this.SelectedCoursesListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 3: // MainPage.xaml line 84
                {
                    this.AddedCoursesListView = (global::Windows.UI.Xaml.Controls.ListView)(target);
                }
                break;
            case 4: // MainPage.xaml line 95
                {
                    this.SubmittedCoursesListView = (global::Microsoft.Toolkit.Uwp.UI.Controls.DataGrid)(target);
                }
                break;
            case 5: // MainPage.xaml line 106
                {
                    this.Notification = (global::Microsoft.Toolkit.Uwp.UI.Controls.InAppNotification)(target);
                }
                break;
            case 6: // MainPage.xaml line 58
                {
                    global::Windows.UI.Xaml.Controls.Button element6 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element6).Click += this.AddButton_OnClick;
                }
                break;
            case 7: // MainPage.xaml line 63
                {
                    global::Windows.UI.Xaml.Controls.Button element7 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element7).Click += this.RemoveButton_OnClick;
                }
                break;
            case 8: // MainPage.xaml line 68
                {
                    global::Windows.UI.Xaml.Controls.Button element8 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element8).Click += this.AddAllButton_OnClick;
                }
                break;
            case 9: // MainPage.xaml line 73
                {
                    global::Windows.UI.Xaml.Controls.Button element9 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element9).Click += this.RemoveAllButton_OnClick;
                }
                break;
            case 10: // MainPage.xaml line 78
                {
                    global::Windows.UI.Xaml.Controls.Button element10 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element10).Click += this.SubmitButton_OnClick;
                }
                break;
            case 11: // MainPage.xaml line 30
                {
                    this.AvailableCoursesComboBox = (global::Windows.UI.Xaml.Controls.ComboBox)(target);
                }
                break;
            case 12: // MainPage.xaml line 37
                {
                    global::Windows.UI.Xaml.Controls.Button element12 = (global::Windows.UI.Xaml.Controls.Button)(target);
                    ((global::Windows.UI.Xaml.Controls.Button)element12).Click += this.SelectButton_OnClick;
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        /// <summary>
        /// GetBindingConnector(int connectionId, object target)
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 10.0.19041.685")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            switch(connectionId)
            {
            case 1: // MainPage.xaml line 1
                {                    
                    global::Windows.UI.Xaml.Controls.Page element1 = (global::Windows.UI.Xaml.Controls.Page)target;
                    MainPage_obj1_Bindings bindings = new MainPage_obj1_Bindings();
                    returnValue = bindings;
                    bindings.SetDataRoot(this);
                    this.Bindings = bindings;
                    element1.Loading += bindings.Loading;
                    global::Windows.UI.Xaml.Markup.XamlBindingHelper.SetDataTemplateComponent(element1, bindings);
                }
                break;
            }
            return returnValue;
        }
    }
}
