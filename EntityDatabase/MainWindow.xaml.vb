Imports EntityDatabase.Modules.Departments.ViewModels
Imports EntityDatabase.Modules.Courses.ViewModels
Imports EntityDatabase.Modules.Persons.ViewModels
Imports EntityDatabase.Modules.OnsiteCourses.ViewModels
Imports EntityDatabase.Modules.OnlineCourses.ViewModels
Imports EntityDatabase.Modules.StudentsGrade.ViewModels
Imports EntityDatabase.Modules.OfficesAssignment.ViewModels
Class MainWindow
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.PersonsUserControl.MainGrid.DataContext = New PersonsViewModel()
        Me.CoursesUserControls.MainGrid.DataContext = New CoursesViewModel()
        Me.DepartmentsUserControls.MainGrid.DataContext = New DepartmentsViewModel()
        Me.OfficesAssignmentUserControls.MainGrid.DataContext = New OfficesAssignmentViewModel()
        Me.OnlineCoursesUserControls.MainGrid.DataContext = New OnlineCourseViewModel()
        Me.OnsiteCoursesUserControls.MainGrid.DataContext = New OnsiteCoursesViewModel()
        Me.StudentsGradeUserControls.MainGrid.DataContext = New StudentsGradeViewModel()
    End Sub
End Class
