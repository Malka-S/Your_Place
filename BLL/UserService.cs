using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.DTO;
using DAL;
using Converters;


namespace BLL
{
  public class UserService
  {

    public static List<UserDto> GetAllUsers()
    {
      return
        UserConverter.ToDtoUserList(UserDal.SelectUsers());
    }
    //איזה סוג הפונקציה מחזירה?
    public static Users GetUserByEmail(string mail)
    {
      try
      {
        return UserDal.SalectUser(mail);
      }
      catch (Exception e)
      {
        throw e;
      }
    }
    public static int AddUser(UserDto user)
    {
      try
      {
        return UserDal.AddUser(UserConverter.ToDalUser(user));
      }
      catch (Exception e)
      {

        throw e;
      }
    }
  }
}
