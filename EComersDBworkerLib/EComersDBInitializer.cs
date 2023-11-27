using EcomersCryptoLib;
using EComersObjectLib;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EComersDBworkerLib
{
    public static class EComersDBInitializer
    {
        public static void EComersDBInitializ(EComersContext eComersContext, bool drop)
        {
            try
            {
                if (drop) eComersContext.Database.EnsureDeleted();
                eComersContext.Database.EnsureCreated();
                
                if (eComersContext.Description.Any())
                {
                    return ;
                }
                else
                {
                    List<Description> descriptionList = new List<Description>()
                    {
                        new Description()
                        {
                            DescriptionId = 1,
                            DescriptionText = "Administrator",
                            LangCod = "EN",
                            CreatedDate = DateTime.UtcNow,
                        },
                        new Description()
                        {
                            DescriptionId = 1,
                            DescriptionText = "Администратор",
                            LangCod = "RU",
                            CreatedDate = DateTime.UtcNow,
                        },
                        new Description()
                        {
                            DescriptionId = 2,
                            DescriptionText = "User",
                            LangCod = "EN",
                            CreatedDate = DateTime.UtcNow,
                        },
                        new Description()
                        {
                            DescriptionId = 2,
                            DescriptionText = "Пользователь",
                            LangCod = "RU",
                            CreatedDate = DateTime.UtcNow,
                        },
                        new Description()
                        {
                            DescriptionId = 3,
                            DescriptionText = "Activ",
                            LangCod = "EN",
                            CreatedDate = DateTime.UtcNow,
                        },
                        new Description()
                        {
                            DescriptionId = 3,
                            DescriptionText = "Активен",
                            LangCod = "RU",
                            CreatedDate = DateTime.UtcNow,
                        },
                        new Description()
                        {
                            DescriptionId = 4,
                            DescriptionText = "Removed",
                            LangCod = "EN",
                            CreatedDate = DateTime.UtcNow,
                        },
                        new Description()
                        {
                            DescriptionId = 4,
                            DescriptionText = "Удален",
                            LangCod = "RU",
                            CreatedDate = DateTime.UtcNow,
                        }
                        ,
                        new Description()
                        {
                            DescriptionId = 5,
                            DescriptionText = "Man",
                            LangCod = "EN",
                            CreatedDate = DateTime.UtcNow,
                        },
                        new Description()
                        {
                            DescriptionId = 6,
                            DescriptionText = "Woman",
                            LangCod = "EN",
                            CreatedDate = DateTime.UtcNow,
                        }
                    };

                    descriptionList.ForEach(description => eComersContext.Description.Add(description));
                    eComersContext.SaveChanges();

                    List<Gender> genderList = new List<Gender>()
                    {
                        new Gender()
                        {
                            GenderCod = "Men",
                            DescriptionId = 5,
                            DefaultGenderDescription = "Men"
                        },
                        new Gender()
                        {
                            GenderCod = "Women",
                            DescriptionId = 6,
                            DefaultGenderDescription = "Women"
                        },
                    };

                    genderList.ForEach(gender => eComersContext.Gender.Add(gender));
                    eComersContext.SaveChanges();

                    List<EmployeStatus> employeStatusesList = new List<EmployeStatus>()
                    {
                        new EmployeStatus()
                        {
                            Cod = "Work",
                            DefaultDescription = "Work"
                        },
                        new EmployeStatus()
                        {
                            Cod = "Fired",
                            DefaultDescription = "Fired"
                        }
                    };
                    employeStatusesList.ForEach(employeStatus => eComersContext.EmployeStatus.Add(employeStatus));
                    eComersContext.SaveChanges();

                    List<UserStatus> userStatusList = new List<UserStatus>()
                    {
                        new UserStatus()
                        {
                            Cod = "Act",
                            DescriptionId = 3,
                            DefaultDescription = "Activen"
                        },
                        new UserStatus()
                        {
                            Cod = "Rem",
                            DescriptionId = 4,
                            DefaultDescription = "Removed"
                        }
                    };

                    userStatusList.ForEach(useStatus => eComersContext.UsersStatus.Add(useStatus));
                    eComersContext.SaveChanges();

                    List<Role> rolesList = new List<Role>()
                    {
                        new Role()
                        {
                            Cod = "Admin",
                            DescriptionId = 1,
                            CreatedDate = DateTime.UtcNow
                            
                        },
                        new Role()
                        {
                            Cod = "User",
                            DescriptionId = 2,
                            CreatedDate = DateTime.UtcNow
                            
                        }
                    };

                    rolesList.ForEach(role => eComersContext.Role.Add(role));
                    eComersContext.SaveChanges();
                    
                    List<User> userList = new List<User>()
                    {
                        new User()
                        {
                            Name = "Administrator",
                            Login = "root",
                            PasswordHash = "AAM/sGNR8Uof4d5O9HoOY2G6sBgGRjwlaphUI7bifPEx9HElerS1981uuD67GjaKlg==", //pas
                            RoleId = 1,
                            StatusId = 1,
                            CreatedDate = DateTime.UtcNow,
                            CreatedUserId = 1,
                        },
                        new User()
                        {
                            Name = "User",
                            SecondName = "Test",
                            PasswordHash = EcomersCrypto.GetHashPassword("user12"),
                            RoleId = 2,
                            StatusId = 1,
                            CreatedDate = DateTime.UtcNow,
                            CreatedUserId = 1,
                        }
                    };

                    userList.ForEach(user => eComersContext.User.Add(user));
                    eComersContext.SaveChanges();

                    eComersContext.Database.ExecuteSqlRaw("INSERT INTO ecomers.\"MerchProductGroup\"(\r\n\t\"GroupName\", \"Description\", \"Cod\")\r\n\tVALUES ('1 - nji topar','1 - nji topar', '1'),('2 - nji topar','2 - nji topar', '2'),('3 - nji topar','3 - nji topar', '3'),('UNIVERSAL','UNIVERSAL', 'UNIVERSAL');");
                    eComersContext.Database.ExecuteSqlRaw("INSERT INTO ecomers.\"MerchProduct\"(\r\n\t \"MerchProductGroupId\", \"MerchProductName\")\r\n\tVALUES \r\n\t( 1, 'Nur bedreli maýonez'),\r\n\t( 1, 'Nur doypack maýonez'),\r\n\t( 1, 'Nur bedreli ketçup'),\r\n\t( 1, 'Nur doypack ketçup'),\r\n\t( 1, 'Nur marinada'),\r\n\t( 1, 'Nur Jem'),\r\n\t( 1, 'Nur Dipah'),\r\n\t( 1, 'Nur Spred'),\r\n\t( 1, 'Almeni Günterek önümleri'),\r\n\t( 1, 'Sep meni nahar duzy'),\r\n\t( 2, '\"Aldiva\" (konditer)'),\r\n\t( 2, 'Aýly Sähra marinada'),\r\n\t( 2, 'Aýly Sähra şerbet'),\r\n\t( 2, 'Rahat lukum gr'),\r\n\t( 2, 'Rahat lukum kg'),\r\n\t( 2, 'Deňiz duzy'),\r\n\t( 2, 'Peýkam ýarmalar'),\r\n\t( 2, '\"Genç\" ary baly'),\r\n\t( 2, 'Misgär konditer'),\r\n\t( 3, '\"Maria\" margarin'),\r\n\t( 3, 'Chiya chips'),\r\n\t( 3, 'SIMORGH'),\r\n\t( 3, 'Eýran kekslary'),\r\n\t( 3, '\"Agam\" nahar duzy'),\r\n\t( 3, 'Altyn jam çaý'),\r\n\t( 3, '\"Baýram\" burç'),\r\n\t( 3, '\"Baýram\" spesii'),\r\n\t( 3, 'GLO sabyn'),\r\n\t( 3, '\"RUBSY\"'),\r\n\t( 3, 'Jaan tämizleýji'),\r\n\t( 3, 'Best'),\r\n\t( 3, 'Etap'),\r\n\t( 3, 'Zer'),\r\n\t( 3, 'Gülaýym'),\r\n\t( 3, 'Dürli'),\r\n\t( 3, 'Suwuk gap-gaç ýuwujy serişde'),\r\n\t( 3, 'MAX britwa'),\r\n\t( 3, 'Hammam duzy'),\r\n\t( 2, 'Balaş makaron'),\r\n\t( 2, '\"Sollo\" kofe'),\r\n\t( 3, 'UNILEVER'),\r\n\t( 3, 'SIMORGH   KG'),\r\n\t( 3, '\"Nilito\" konditer'),\r\n\t( 3, 'Berzeňňi witamin'),\r\n\t( 3, '\"Berzeňňi\" gazly 1,5 l'),\r\n\t( 3, '\"Berzeňňi\" gazly 0,250ml'),\r\n\t( 3, '\"Berzeňňi\" gazly 500ml'),\r\n\t( 3, '\"Berzeňňi\" gazsyz 0,250ml');");
                }
            }
            catch(Exception ex)
            {
                string message = ex.Message;
            }
            
        }
    }
}
