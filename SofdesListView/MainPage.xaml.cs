using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace SofdesListView
{
    public sealed partial class MainPage : Page
    {

        public ObservableCollection<Course> AvailableCourses = new ObservableCollection<Course>()
        {
            new Course("CISCO1", "CISCO 1", 3),
            new Course("CW", "The Contemporary World", 3),
            new Course("ECECIR", "Fundamentals of Electronic Circuits", 4),
            new Course("ETHICS", "Ethics", 3),
            new Course("NUMMET", "Numerical Methods", 3),
            new Course("PEF4", "PATH-Fit4", 2),
            new Course("SOFDES", "Software Design", 4),
            new Course("UTS", "Understanding the Self", 3)
        };

        public ObservableCollection<Course> SelectedCourses = new ObservableCollection<Course>();

        public ObservableCollection<Course> AddedCourses = new ObservableCollection<Course>();

        public ObservableCollection<Course> SubmittedCourses = new ObservableCollection<Course>();

        public MainPage()
        {
            InitializeComponent();
        }

        private void SelectButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (AvailableCoursesComboBox.SelectedItem is Course selectedCourse)
            {
                SelectedCourses.Add(selectedCourse);
                AvailableCourses.Remove(selectedCourse);
            }
            else
            {
                Notification.Show("Choose a course to select from the dropdown first.", 2000);
            }
        }

        private void AddButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (SelectedCoursesListView.SelectedItem is Course addedCourse)
            {
                AddedCourses.Add(addedCourse);
                SelectedCourses.Remove(addedCourse);
            }
            else
            {
                Notification.Show("Choose a course to add from the left list first.", 2000);
            }
        }

        private void RemoveButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (AddedCoursesListView.SelectedItem is Course removedCourse)
            {
                SelectedCourses.Add(removedCourse);
                AddedCourses.Remove(removedCourse);
            }
            else
            {
                Notification.Show("Choose a course to remove from the right list first.", 3000);
            }
        }

        private void AddAllButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (SelectedCourses.Count <= 0)
            {
                Notification.Show("Choose courses from the dropdown above first.", 3000);
            }
            while (SelectedCourses.Count > 0)
            {
                var addedCourse = SelectedCourses[0];
                AddedCourses.Add(addedCourse);
                SelectedCourses.Remove(addedCourse);
            }
        }

        private void RemoveAllButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (AddedCourses.Count <= 0)
            {
                Notification.Show("There are no courses to remove.", 3000);
            }
            while (AddedCourses.Count > 0)
            {
                var removedCourse = AddedCourses[0];
                SelectedCourses.Add(removedCourse);
                AddedCourses.Remove(removedCourse);
            }
        }

        private void SubmitButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (AddedCourses.Count <= 0)
            {
                Notification.Show("Add courses from the left list to the right list first to submit.", 3000);
            }
            else
            {
                SubmittedCourses.Clear();
                foreach (var submittedCourse in AddedCourses)
                {
                    SubmittedCourses.Add(submittedCourse);
                }
            }
            
        }
    }
}