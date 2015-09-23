Imports EntityDatabase.BusinessLogic.Services.Interfaces
Imports EntityDatabase.BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class OfficeAssignmentService
        Implements IOfficeAssignmentService
        Public Function GetAllOfficeAssignment() As IQueryable(Of OfficeAssignment) Implements IOfficeAssignmentService.GetAllOfficeAssignment
            Return DataContext.DBEntities.OfficeAssignments
        End Function
    End Class
End Namespace