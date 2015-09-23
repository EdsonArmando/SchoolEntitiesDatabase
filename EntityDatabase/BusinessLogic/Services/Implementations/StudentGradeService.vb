Imports EntityDatabase.BusinessLogic.Services.Interfaces
Imports EntityDatabase.BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class StudentGradeService
        Implements IStudentGradeService

        Public Function GetAllStudentsGrade() As IQueryable(Of StudentGrade) Implements IStudentGradeService.GetAllStudentsGrade
            Return DataContext.DBEntities.StudentGrades
        End Function
    End Class
End Namespace