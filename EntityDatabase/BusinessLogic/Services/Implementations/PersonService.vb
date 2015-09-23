Imports EntityDatabase.BusinessLogic.Services.Interfaces
Imports EntityDatabase.BusinessObjects.Helpers
Namespace BusinessLogic.Services.Implementations
    Public Class PersonService
        Implements IPersonService
        Public Function GetAllPersons() As IQueryable(Of Person) Implements IPersonService.GetAllPersons
            Return DataContext.DBEntities.People
        End Function

        Public Sub PersoneConsult()

        End Sub
    End Class
End Namespace