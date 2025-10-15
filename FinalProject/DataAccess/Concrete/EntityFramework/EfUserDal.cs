using System;
using Core.DataAccess.EntityFramework;
using Core.Entitites.Concrete;
using DataAccess.Abstract;

namespace DataAccess.Concrete.EntityFramework;

public class EfUserDal:EfEntityRepositoryBase<User,NorthwindContext>,IUserDal
{
    public List<OperationClaim> GetClaims(User user)
    {
        // using (var context = new NorthwindContext())
        // {
        //     var result = from operationClaim in context.OperationClaims
        //                  join userOperationClaim in context.UserOperationClaims
        //                      on operationClaim.Id equals userOperationClaim.OperationClaimId
        //                  where userOperationClaim.UserId == user.Id
        //                  select new OperationClaim { Id = operationClaim.Id, Name = operationClaim.Name };
        //     return result.ToList();
        // }

        using(var context = new NorthwindContext())
        {
            var result = context.OperationClaims.Join(
                context.UserOperationClaims,
                operationClaim => operationClaim.Id,
                userOperationClaim => userOperationClaim.UserId,
                (operationClaim, userOperationClaim) => new { operationClaim, userOperationClaim }
            ).Where(joinedResult => joinedResult.userOperationClaim.UserId == user.Id)
            .Select(joinedResult => new OperationClaim
            {
                Id = joinedResult.operationClaim.Id,
                Name = joinedResult.operationClaim.Name
            });
            return result.ToList();
        }
            

    }
}
