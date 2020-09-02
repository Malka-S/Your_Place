using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
   public class UsersService
    {
        public static int UpdateUsers(Common.DTO.UsersDto user)
        {
            try
            {
                return DAL.UsersDal.UpdateUsers(Converters.UsersConverter.ToDalUsers(user));
            }
            catch (Exception e)
            {

                throw;
            }
        }
        public static int AddUsers(Common.DTO.UsersDto user)
        {
            try
            {
                return DAL.UsersDal.AddUser(Converters.UsersConverter.ToDalUsers(user));
            }
            catch (Exception e)
            {

                throw;
            }
        }
    }
}
