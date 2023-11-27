using SAPbobsCOM;
using EComersObjectLib.SapObjects;
using System;
using System.Collections.Generic;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;
using EComersObjectLib.Objects;
using Microsoft.VisualBasic;
using EComersObjectLib;
using System.Xml.Linq;

namespace SapDBWorkerLib
{
    public class SapDBWorker
    {
        public Company company = new Company()
        {
            Server = "NDB@192.168.2.111:30013",
            SLDServer = "192.168.2.111:40000",
            DbServerType = BoDataServerTypes.dst_HANADB,
            LicenseServer = "192.168.2.111:40000",
            CompanyDB = "TEST",
            //UserName = "test",
            //Password = "Asdf1234",
            //UserName = "kurban",
            //Password = "Guller@123",
            UserName = "manager",
            Password = "matest12",
            //UserName = "muhammed.s",
            //Password = "Asdf1234",

            DbUserName = "SYSTEM",
            DbPassword = "253ngkxB",
            language = BoSuppLangs.ln_Russian,
            UseTrusted = true
        };

        public SapDBWorker()
        {

        }

        public bool Connect()
        {
            try
            {
                if (company.Connect() != 0)
                {
                    Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Connection is failed: " + company.GetLastErrorCode().ToString() + " " + company.GetLastErrorDescription());

                    return false;
                }
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Problem with connection: " + ex.Message);
                return false;
            }
        }

        public void Disconnect()
        {
            try
            {
                if (company.Connected == true)
                {
                    company.Disconnect();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + " - Problem with disconnection: " + ex.Message);
            }
        }


        public void SetSapConnectonOption(string server, string sdlServer, int boDataServerTypes, string licenseServer, string companyDB, string userName, string password, string dbUserName, string dbPassword, int _language, bool useTrusted)
        {
            company = new Company()
            {
                Server = server,
                SLDServer = sdlServer,
                DbServerType = (BoDataServerTypes)boDataServerTypes,
                LicenseServer = licenseServer,
                CompanyDB = companyDB,
                UserName = userName,
                Password = password,
                DbUserName = dbUserName,
                DbPassword = dbPassword,
                language = (BoSuppLangs)_language,
                UseTrusted = useTrusted
            };
        }

        public List<OINV> GetListInvoice(int ownerCode)
        {
            List<OINV> listInvoice = new List<OINV>();

            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select \r\n\toinv.\"DocEntry\",\r\n\toinv.\"DocNum\",\r\n\toinv.\"DocDate\",\r\n\toinv.\"CardCode\",\r\n\toinv.\"CardName\",\r\n\toinv.\"DocTotal\",\r\n\toinv.\"OwnerCode\",\r\n\toinv.\"DocStatus\",\r\n\toinv.\"GroupNum\"\r\nfrom \r\n\tTest.oinv oinv\r\nwhere \r\n\toinv.\"DocStatus\" = 'O'\r\n\tand oinv.\"OwnerCode\" = {ownerCode}");
            while (!recordset.EoF)
            {
                OINV _OINV = new OINV()
                {
                    DocEntry = (int)recordset.Fields.Item("DocEntry").Value,
                    DocNum = (int)recordset.Fields.Item("DocNum").Value,
                    DocDate = recordset.Fields.Item("DocDate").Value,
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    DocTotal = (double)recordset.Fields.Item("DocTotal").Value,
                    OwnerCode = (int)recordset.Fields.Item("OwnerCode").Value,
                    DocStatus = recordset.Fields.Item("DocStatus").Value,
                    GroupNum = (int)recordset.Fields.Item("GroupNum").Value,
                    PaySum = 0
                };

                listInvoice.Add(_OINV);
                recordset.MoveNext();
            }
            return listInvoice;
        }

        public List<OINV> GetListInvoiceByExpeditor(string uAgent)
        {
            List<OINV> listInvoice = new List<OINV>();

            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select \r\n\toinv.\"DocEntry\",\r\n\toinv.\"DocNum\",\r\n\toinv.\"DocDate\",\r\n\toinv.\"CardCode\",\r\n\toinv.\"CardName\",\r\n\toinv.\"DocTotal\",\r\n\toinv.\"OwnerCode\",\r\n\toinv.\"DocStatus\",\r\n\toinv.\"GroupNum\"\r\nfrom test.oinv oinv where  oinv.\"U_Agent\" = '{uAgent}' and oinv.\"DocStatus\" = 'O'");
            while (!recordset.EoF)
            {
                OINV _OINV = new OINV()
                {
                    DocEntry = (int)recordset.Fields.Item("DocEntry").Value,
                    DocNum = (int)recordset.Fields.Item("DocNum").Value,
                    DocDate = recordset.Fields.Item("DocDate").Value,
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    DocTotal = (double)recordset.Fields.Item("DocTotal").Value,
                    OwnerCode = (int)recordset.Fields.Item("OwnerCode").Value,
                    DocStatus = recordset.Fields.Item("DocStatus").Value,
                    GroupNum = (int)recordset.Fields.Item("GroupNum").Value,
                    PaySum = 0
                };

                listInvoice.Add(_OINV);
                recordset.MoveNext();
            }
            return listInvoice;
        }

        public List<OINV> GetListInvoiceByDocNumber(string docNumber)
        {
            List<OINV> listInvoice = new List<OINV>();
            /*
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select \r\n\toinv.\"DocEntry\",\r\n\toinv.\"DocNum\",\r\n\toinv.\"DocDate\",\r\n\toinv.\"CardCode\",\r\n\toinv.\"CardName\",\r\n\toinv.\"DocTotal\",\r\n\toinv.\"OwnerCode\",\r\n\toinv.\"DocStatus\",\r\n\toinv.\"GroupNum\"\r\nfrom test.oinv oinv where  oinv.\"U_Agent\" = '{uAgent}' and oinv.\"DocStatus\" = 'O'");
            while (!recordset.EoF)
            {
                OINV _OINV = new OINV()
                {
                    DocEntry = (int)recordset.Fields.Item("DocEntry").Value,
                    DocNum = (int)recordset.Fields.Item("DocNum").Value,
                    DocDate = recordset.Fields.Item("DocDate").Value,
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    DocTotal = (double)recordset.Fields.Item("DocTotal").Value,
                    OwnerCode = (int)recordset.Fields.Item("OwnerCode").Value,
                    DocStatus = recordset.Fields.Item("DocStatus").Value,
                    GroupNum = (int)recordset.Fields.Item("GroupNum").Value,
                    PaySum = 0
                };

                listInvoice.Add(_OINV);
                recordset.MoveNext();
            }
            */
            return listInvoice;
        }

        public List<OITM> GetListItems(string empID)
        {
            List<OITM> listItems = new List<OITM>();
            string whsCode = GetWarehouseCode(empID);
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlGetItemsByEmpID.Replace("WHSCODE", whsCode));

            while (!recordset.EoF)
            {
                OITM _OITM = new OITM()
                {
                    ItemCode = recordset.Fields.Item("ItemCode").Value,
                    ItemName = recordset.Fields.Item("ItemName").Value,
                    Price = (double)recordset.Fields.Item("Price").Value,
                    WhsName = recordset.Fields.Item("WhsName").Value,
                    ItemCount = (double)recordset.Fields.Item("ItemCount").Value,
                    PicturName = recordset.Fields.Item("PicturName").Value,
                    ItmsGrpCod = (int)recordset.Fields.Item("ItmsGrpCod").Value
                };
                listItems.Add(_OITM);
                recordset.MoveNext();
            }
            return listItems;
        }

        public int GetItemWhsCount(string itemCode)
        {
            int listItems = 0;

            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"SELECT oitw.\"OnHand\"-oitw.\"IsCommited\" as ItemCount FROM TEST.\"OITM\" as oitm, TEST.\"OITW\" as oitw where oitm.\"frozenFor\" = 'N' and oitw.\"ItemCode\" = oitm.\"ItemCode\" and oitw.\"WhsCode\" = 'YALKYM' and oitm.\"ItmsGrpCod\" = 101 and oitm.\"ItemCode\" = '{itemCode}' limit 1;");
            if (recordset.RecordCount > 0)
            {
                recordset.MoveFirst();
                listItems =(int) recordset.Fields.Item("ItemCount").Value;
            }
             return listItems;
        }

        public int GetItemWhsCount(string itemCode, string whsCode)
        {
            int listItems = 0;

            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"SELECT oitw.\"OnHand\"-oitw.\"IsCommited\" as ItemCount FROM TEST.\"OITM\" as oitm, TEST.\"OITW\" as oitw where oitm.\"frozenFor\" = 'N' and oitw.\"ItemCode\" = oitm.\"ItemCode\" and oitw.\"WhsCode\" = '{whsCode}' and oitm.\"ItmsGrpCod\" = 101 and oitm.\"ItemCode\" = '{itemCode}' limit 1;");
            if (recordset.RecordCount > 0)
            {
                recordset.MoveFirst();
                listItems = (int)recordset.Fields.Item("ItemCount").Value;
            }
            return listItems;
        }
        public List<OCRD> GetListCustomers()
        {
            List<OCRD> listCustomers = new List<OCRD>();

            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"SELECT * FROM TEST.OCRD where \"validFor\" = 'Y' and \"CardType\" = 'C' and \"GroupCode\" in (100,103)");
            while (!recordset.EoF)
            {
                OCRD _OCRD = new OCRD()
                {
                    CardCode = recordset.Fields.Item("CardCode").Value,                   
                    CardName = recordset.Fields.Item("CardName").Value,
                    Phone1 = recordset.Fields.Item("Phone1").Value,
                    Free_Text = recordset.Fields.Item("Free_Text").Value,
                    Notes = recordset.Fields.Item("Notes").Value,
                    U_lat = recordset.Fields.Item("U_lat").Value,
                    U_lng = recordset.Fields.Item("U_lng").Value,
                    U_RouteID = recordset.Fields.Item("U_RouteID").Value
                };
                listCustomers.Add(_OCRD);
                recordset.MoveNext();
            }
            return listCustomers;
        }

        public List<OCRD> GetListCustomersByCardName(string cardName)
        {
            List<OCRD> listCustomers = new List<OCRD>();

            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"SELECT * FROM TEST.OCRD where \"validFor\" = 'Y' and \"GroupCode\" in (100,103) and \"CardName\" like \'%{cardName}%\'");
            while (!recordset.EoF)
            {
                OCRD _OCRD = new OCRD()
                {
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    Phone1 = recordset.Fields.Item("Phone1").Value,
                    Free_Text = recordset.Fields.Item("Free_Text").Value,
                    Notes = recordset.Fields.Item("Notes").Value,
                    U_lat = recordset.Fields.Item("U_lat").Value,
                    U_lng = recordset.Fields.Item("U_lng").Value,
                    U_RouteID = recordset.Fields.Item("U_RouteID").Value
                };
                listCustomers.Add(_OCRD);
                recordset.MoveNext();
            }
            return listCustomers;
        }

        public List<RDR1> GetListSapOrdersLines(int docEntry)
        {
            List<RDR1> listRDR1 = new List<RDR1>();

            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select * from TEST.RDR1 rdr1 where rdr1.\"DocEntry\" = {docEntry}");
            while (!recordset.EoF)
            {
                RDR1 _RDR1 = new RDR1()
                {
                    DocEntry = (int)recordset.Fields.Item("DocEntry").Value,
                    LineNum = (int)recordset.Fields.Item("LineNum").Value,
                    ItemCode = recordset.Fields.Item("ItemCode").Value,
                    Description = recordset.Fields.Item("Dscription").Value,
                    Quantity = (double)recordset.Fields.Item("Quantity").Value,
                    Price = (double)recordset.Fields.Item("Price").Value,
                    LineTotal = (double)recordset.Fields.Item("LineTotal").Value,
                    WhsCode = recordset.Fields.Item("WhsCode").Value
                };
                listRDR1.Add(_RDR1);
                recordset.MoveNext();
            }

            return listRDR1;
        }

        public List<EmployeRoot> GetSapEmployeRoot(int empId)
        {
            List<EmployeRoot> employeRoots = new List<EmployeRoot>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select htm.\"empID\", ohtm.\"name\" from test.HTM1 htm, test.OHTM ohtm where htm.\"teamID\" = ohtm.\"teamID\" and htm.\"empID\" = {empId}");

            if (recordset.RecordCount == 0)
            {
                return employeRoots;
            }

            while (!recordset.EoF)
            {
                EmployeRoot empRoot = new EmployeRoot()
                {
                    EmployeId = int.Parse(recordset.Fields.Item("empID").Value.ToString()),
                    Root = recordset.Fields.Item("name").Value,
                };
                employeRoots.Add(empRoot);
                recordset.MoveNext();
            }

            return employeRoots;
        }

        public OHEM GetSapEmployeByCode(int code)
        {
            OHEM ohem = new OHEM();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select ohem.\"empID\", ohem.\"firstName\", ohem.\"lastName\", ohem.\"middleName\", ohem.\"sex\", ohem.\"jobTitle\", ohem.\"dept\", ohem.\"birthDate\",ohem.\"mobile\",ohem.\"homeTel\",ohem.\"email\",ohem.\"workStreet\",ohem.\"workCity\"  from test.OHEM ohem where ohem.\"empID\" = {code}");

            if(recordset.RecordCount > 0 ) 
            {
                recordset.MoveFirst();
                
                ohem.empId = (int)recordset.Fields.Item("empID").Value;
                ohem.firstName = recordset.Fields.Item("firstName").Value;
                ohem.lastName = recordset.Fields.Item("lastName").Value;
                ohem.middleName = recordset.Fields.Item("middleName").Value;
                ohem.sex = recordset.Fields.Item("sex").Value;
                ohem.jobTitle = recordset.Fields.Item("jobTitle").Value;
                ohem.dept = recordset.Fields.Item("dept").Value;
                ohem.birthDay = recordset.Fields.Item("birthDate").Value;
                ohem.mobile = recordset.Fields.Item("mobile").Value;
                ohem.homeTel = recordset.Fields.Item("homeTel").Value;
                ohem.email = recordset.Fields.Item("email").Value;
                ohem.workStreet = recordset.Fields.Item("workStreet").Value;
                ohem.workCity = recordset.Fields.Item("workCity").Value;
            }

            return ohem;
        } 

        public List<OHEM> GetListSapEmploye()
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery("select ohem.\"empID\", ohem.\"firstName\", ohem.\"lastName\", ohem.\"middleName\", ohem.\"sex\", ohem.\"jobTitle\", ohem.\"dept\", ohem.\"birthDate\",ohem.\"mobile\",ohem.\"homeTel\",ohem.\"email\",ohem.\"workStreet\",ohem.\"workCity\" from test.OHEM ohem;");
            List<OHEM> OHEMlist = new List<OHEM>();

            if (recordset.RecordCount == 0)
            {
                return new List<OHEM>();
            }

            while (!recordset.EoF)
            {
                OHEM oHEM = new OHEM()
                {
                    empId = int.Parse(recordset.Fields.Item("empID").Value.ToString()),
                    firstName = recordset.Fields.Item("firstName").Value,
                    lastName = recordset.Fields.Item("lastName").Value,
                    middleName = recordset.Fields.Item("middleName").Value,
                    sex = recordset.Fields.Item("sex").Value,
                    jobTitle = recordset.Fields.Item("jobTitle").Value,
                    dept = recordset.Fields.Item("dept").Value,
                    birthDay = recordset.Fields.Item("birthDate").Value,
                    mobile = recordset.Fields.Item("mobile").Value,
                    homeTel = recordset.Fields.Item("homeTel").Value,
                    email = recordset.Fields.Item("email").Value,
                    workStreet = recordset.Fields.Item("workStreet").Value,
                    workCity = recordset.Fields.Item("workCity").Value
                };
                OHEMlist.Add(oHEM);
                recordset.MoveNext();
            }


            return OHEMlist;
        }

        public List<OHEM> GetListSapEmploye(string jobTitle, string region)
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlGetExpedirotByRegion.Replace("TITLE", $"\'{jobTitle}\'").Replace("REGION", region));
            List<OHEM> OHEMlist = new List<OHEM>();

            if (recordset.RecordCount == 0)
            {
                return new List<OHEM>();
            }

            while (!recordset.EoF)
            {
                OHEM oHEM = new OHEM()
                {
                    empId = int.Parse(recordset.Fields.Item("empID").Value.ToString()),
                    firstName = recordset.Fields.Item("firstName").Value,
                    lastName = recordset.Fields.Item("lastName").Value,
                    middleName = recordset.Fields.Item("middleName").Value,
                    sex = recordset.Fields.Item("sex").Value,
                    jobTitle = recordset.Fields.Item("jobTitle").Value,
                    dept = recordset.Fields.Item("dept").Value,
                    birthDay = recordset.Fields.Item("birthDate").Value,
                    mobile = recordset.Fields.Item("mobile").Value,
                    homeTel = recordset.Fields.Item("homeTel").Value,
                    email = recordset.Fields.Item("email").Value,
                    workStreet = recordset.Fields.Item("workStreet").Value,
                    workCity = recordset.Fields.Item("workCity").Value
                };
                OHEMlist.Add(oHEM);
                recordset.MoveNext();
            }


            return OHEMlist;
        }

        public List<OHEM> GetListSapEmploye(string jobTitle)
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlEmployeByJobTitle.Replace("TITLE",$"\'{jobTitle}\'"));
            List<OHEM> OHEMlist = new List<OHEM>();

            if (recordset.RecordCount == 0)
            {
                return new List<OHEM>();
            }

            while (!recordset.EoF)
            {
                OHEM oHEM = new OHEM()
                {
                    empId = int.Parse(recordset.Fields.Item("empID").Value.ToString()),
                    firstName = recordset.Fields.Item("firstName").Value,
                    lastName = recordset.Fields.Item("lastName").Value,
                    middleName = recordset.Fields.Item("middleName").Value,
                    sex = recordset.Fields.Item("sex").Value,
                    jobTitle = recordset.Fields.Item("jobTitle").Value,
                    dept = recordset.Fields.Item("dept").Value,
                    birthDay = recordset.Fields.Item("birthDate").Value,
                    mobile = recordset.Fields.Item("mobile").Value,
                    homeTel = recordset.Fields.Item("homeTel").Value,
                    email = recordset.Fields.Item("email").Value,
                    workStreet = recordset.Fields.Item("workStreet").Value,
                    workCity = recordset.Fields.Item("workCity").Value
                };
                OHEMlist.Add(oHEM);
                recordset.MoveNext();
            }


            return OHEMlist;
        }

        public List<object> GetListSapOrders(string ownnerCode) 
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select \"DocEntry\", \r\n\"DocNum\", \r\n\"DocStatus\", \r\n\"DocDate\",\r\n\"DocTime\", \r\n\"CardCode\", \r\n\"CardName\", \r\n\"DocTotal\", \r\n\"GrosProfit\", \r\n\"OwnerCode\" ,\r\n\"GroupNum\",\r\n(CASE WHEN \"GroupNum\"='-1' THEN 'Cash'\r\n  WHEN \"GroupNum\"='1' OR \"GroupNum\"='2' OR \"GroupNum\"='3' OR \"GroupNum\"='4'  THEN 'Credit'\r\n  WHEN \"GroupNum\"='5' THEN 'Bank'\r\n  WHEN \"GroupNum\"='6' THEN 'Consignment'\r\n  END) AS \"PayType\"\r\nfrom TEST.ORDR where \"OwnerCode\" = {ownnerCode} and \"CANCELED\" = 'N';");
            List<object> ORDRlist = new List<object>();

            if (recordset.RecordCount == 0)
            {
                return ORDRlist;
            }

            while (!recordset.EoF)
            {
                ORDR oRDR = new ORDR()
                {
                    DocEntry = (int)recordset.Fields.Item("DocEntry").Value,
                    DocNum = recordset.Fields.Item("DocNum").Value,
                    DocStatus = recordset.Fields.Item("DocStatus").Value,
                    DocDate = ConcateDodate(recordset.Fields.Item("DocDate").Value, recordset.Fields.Item("DocTime").Value),
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    DocTotal = (double)recordset.Fields.Item("DocTotal").Value,
                    GrosProfit = (double)recordset.Fields.Item("GrosProfit").Value,
                    OwnerCode = (int)recordset.Fields.Item("OwnerCode").Value,
                    GroupNum = (int)recordset.Fields.Item("GroupNum").Value,
                    PayType = recordset.Fields.Item("PayType").Value
                    
                };
                ORDRlist.Add(oRDR);
                recordset.MoveNext();
            }
            return ORDRlist;
        }

        public List<object> GetListAllSapOrders()
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select \"DocEntry\", \r\n\"DocNum\", \r\n\"DocStatus\", \r\n\"DocDate\",\r\n\"DocTime\", \r\n\"CardCode\", \r\n\"CardName\", \r\n\"DocTotal\", \r\n\"GrosProfit\", \r\n\"OwnerCode\" ,\r\n\"GroupNum\",\r\n(CASE WHEN \"GroupNum\"='-1' THEN 'Cash'\r\n  WHEN \"GroupNum\"='1' OR \"GroupNum\"='2' OR \"GroupNum\"='3' OR \"GroupNum\"='4'  THEN 'Credit'\r\n  WHEN \"GroupNum\"='5' THEN 'Bank'\r\n  WHEN \"GroupNum\"='6' THEN 'Consignment'\r\n  END) AS \"PayType\",\r\n\"Comments\" from TEST.ORDR where \"DocStatus\" = 'O';");
            List<object> ORDRlist = new List<object>();

            if (recordset.RecordCount == 0)
            {
                return ORDRlist;
            }

            while (!recordset.EoF)
            {
                ORDR oRDR = new ORDR()
                {
                    DocEntry = (int)recordset.Fields.Item("DocEntry").Value,
                    DocNum = recordset.Fields.Item("DocNum").Value,
                    DocStatus = recordset.Fields.Item("DocStatus").Value,
                    DocDate = ConcateDodate(recordset.Fields.Item("DocDate").Value, recordset.Fields.Item("DocTime").Value),
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    DocTotal = (double)recordset.Fields.Item("DocTotal").Value,
                    GrosProfit = (double)recordset.Fields.Item("GrosProfit").Value,
                    OwnerCode = (int)recordset.Fields.Item("OwnerCode").Value,
                    GroupNum = (int)recordset.Fields.Item("GroupNum").Value,
                    PayType = recordset.Fields.Item("PayType").Value,
                    Comments = recordset.Fields.Item("Comments").Value
                };
                ORDRlist.Add(oRDR);
                recordset.MoveNext();
            }
            return ORDRlist;
        }

        public List<object> GetListAllSapOrdersByRegion(string region)
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlGetAllOpenSapOrderByRegion.Replace("REGION", region));
            List<object> ORDRlist = new List<object>();

            if (recordset.RecordCount == 0)
            {
                return ORDRlist;
            }

            while (!recordset.EoF)
            {
                ORDR oRDR = new ORDR()
                {
                    DocEntry = (int)recordset.Fields.Item("DocEntry").Value,
                    DocNum = recordset.Fields.Item("DocNum").Value,
                    DocStatus = recordset.Fields.Item("DocStatus").Value,
                    DocDate = ConcateDodate(recordset.Fields.Item("DocDate").Value, recordset.Fields.Item("DocTime").Value),
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    DocTotal = (double)recordset.Fields.Item("DocTotal").Value,
                    GrosProfit = (double)recordset.Fields.Item("GrosProfit").Value,
                    OwnerCode = (int)recordset.Fields.Item("OwnerCode").Value,
                    GroupNum = (int)recordset.Fields.Item("GroupNum").Value,
                    PayType = recordset.Fields.Item("PayType").Value,
                    Comments = recordset.Fields.Item("Comments").Value
                };
                ORDRlist.Add(oRDR);
                recordset.MoveNext();
            }
            return ORDRlist;
        }

        public int GetNewOrderCode() 
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery("select max(\"DocNum\") as DocNum  from TEST.ORDR");
            List<OHEM> OHEMlist = new List<OHEM>();

            if (recordset.RecordCount == 0)
            {
                return 0;
            }
            else
            {
                if (int.TryParse(recordset.Fields.Item("DocNum").Value.ToString(), out int docMum))
                    return docMum + 1;
                else 
                { 
                    return 0; 
                }
            }
        }
       
        public int GetSlpCode(string empId)
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"SELECT \"salesPrson\" FROM \"OHEM\" WHERE \"empID\" =  {empId} ;");

            if (recordset.RecordCount == 0)
            {
                return 0;
            }

            if (int.TryParse(recordset.Fields.Item("salesPrson").Value.ToString(),out int result))
            {
                return result;
            }

            return 0;
        }

        public int GetOwnerCode(string cCode)
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery("SELECT \"Code\" FROM \"OHEM\" WHERE \"U_EmployeeCode1C\" = '" + cCode + "';");

            if (recordset.RecordCount == 0)
            {
                return 0;
            }

            if (int.TryParse(recordset.Fields.Item("Code").Value.ToString(),out int result))
            {
                return result;
            }

            return 0;
        }


        public bool Connected()
        {
            return company.Connected;
        }

        private static DateTime ConcateDodate(dynamic date, dynamic time)
        {
            int intTime = time;
            string minute = "";
            string strDate = date.ToString();
            string strTime = intTime.ToString();

            string houre = strTime.Length == 4 ? strTime.Substring(0, 2) : "0" + strTime.Substring(0, 1);
            if (strTime.Length > 2)
            {
                minute = strTime.Length == 4 ? strTime.Substring(2, 2) : strTime.Substring(1, 2);
            }
            else { minute = "00"; }
            

            DateTime dateTime = DateTime.Parse(string.Format("{0} {1}:{2}:00.0", strDate.Remove(10, strDate.Length - 10), houre, minute));
            return dateTime;
        }

        public List<OCRD> GetUpdatedListCustomers(string date)
        {
            List<OCRD> listCustomers = new List<OCRD>();

            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"SELECT * FROM TEST.OCRD where \"validFor\" = 'Y' and (\"CreateDate\" > \'{date}\' or \"UpdateDate\" > \'{date}\'  ) ");
            while (!recordset.EoF)
            {
                OCRD _OCRD = new OCRD()
                {
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    Phone1 = recordset.Fields.Item("Phone1").Value,
                    Free_Text = recordset.Fields.Item("Free_Text").Value,
                    Notes = recordset.Fields.Item("Notes").Value,
                    U_lat = recordset.Fields.Item("U_lat").Value,
                    U_lng = recordset.Fields.Item("U_lng").Value
                };
                listCustomers.Add(_OCRD);
                recordset.MoveNext();
            }
            return listCustomers;
        }

        public string GetRootByEmployeByCode(int code)
        {
           string root = string.Empty;

            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select ohtm.\"name\" from test.OHEM ohem, test.HTM1 htm, test.OHTM ohtm where  ohem.\"empID\" = htm.\"empID\"  and htm.\"teamID\" = ohtm.\"teamID\"  and ohem.\"empID\" = {code} limit 1");

            if (recordset.RecordCount == 1)
            {
                recordset.MoveFirst();
                root = recordset.Fields.Item("name").Value;
            }

            return root;
        }

        public List<ODLN> GetListSapDelivery(string empId)
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            //recordset.DoQuery($"select odln.* from Test.ODLN odln where odln.\"U_Agent\" = \'{empId}\' and (odln.\"DocStatus\" = 'O' or (odln.\"DocStatus\" = 'C' and odln.\"GroupNum\" in (5,1,2,3,4,6,7)  and 'O' = (select oinv.\"DocStatus\" from Test.OINV oinv where oinv.\"CANCELED\" = 'N' and oinv.\"DocStatus\" = 'O' and oinv.\"DocEntry\" in (select distinct(inv.\"DocEntry\") from Test.inv1 inv where inv.\"BaseEntry\" = odln.\"DocEntry\" )))) order by \"CardCode\" asc");
            //recordset.DoQuery($"select * from Test.ODLN where \"U_Agent\" = \'{empId}\' and \"DocStatus\" = 'O' order by \"CardCode\" asc");
            recordset.DoQuery(Resource.SqlGetDeliveryByEmpID.Replace("empId", empId));
            List<ODLN> ODLNlist = new List<ODLN>();

            if (recordset.RecordCount == 0)
            {
                return ODLNlist;
            }

            while (!recordset.EoF)
            {
                ODLN oDLN = new ODLN()
                {
                    DocEntry = (int)recordset.Fields.Item("DocEntry").Value,
                    DocNum = (int)recordset.Fields.Item("DocNum").Value,
                    DocStatus = recordset.Fields.Item("DocStatus").Value,
                    DocDate = ConcateDodate(recordset.Fields.Item("DocDate").Value, recordset.Fields.Item("DocTime").Value),
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    DocTotal = (double)recordset.Fields.Item("DocTotal").Value,
                    PayType = recordset.Fields.Item("PayType").Value
                };
                ODLNlist.Add(oDLN);
                recordset.MoveNext();
            }
            return ODLNlist;
        }

        public List<DeliveryItem> GetListSapDeliveryItems(int docEntry)
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select oitm.\"ItemCode\", oitm.\"ItemName\", oitm.\"PicturName\", dln.\"Quantity\", dln.\"Price\", ordr.\"DocNum\", dln.\"BaseRef\", dln.\"BaseEntry\" from test.DLN1 dln, test.oitm oitm, test.ORDR ordr where ordr.\"DocEntry\" = dln.\"BaseEntry\" and dln.\"DocEntry\" = {docEntry} and oitm.\"ItemCode\" = dln.\"ItemCode\";");
            List<DeliveryItem> listItems = new List<DeliveryItem>();

            if (recordset.RecordCount == 0)
            {
                return listItems;
            }

            while (!recordset.EoF)
            {
                DeliveryItem deliveryItem = new DeliveryItem()
                {
                    ItemCode = recordset.Fields.Item("ItemCode").Value,
                    ItemName = recordset.Fields.Item("ItemName").Value,
                    Price = (double)recordset.Fields.Item("Price").Value,
                    Quantity = (int)recordset.Fields.Item("Quantity").Value,
                    PicturName = recordset.Fields.Item("PicturName").Value,
                    DocNum = recordset.Fields.Item("DocNum").Value,
                    BaseRef = recordset.Fields.Item("BaseRef").Value,
                    BaseEntry = recordset.Fields.Item("BaseEntry").Value
                };
                listItems.Add(deliveryItem);
                recordset.MoveNext();
            }
            return listItems;
        }

        public List<DeliveryItem> GetListSapDeliveryItemsByEmpId(int empId)
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select odln.\"DocEntry\", oitm.\"ItemCode\", oitm.\"ItemName\", oitm.\"PicturName\", dln.\"Quantity\", dln.\"Price\", ordr.\"DocNum\", dln.\"BaseRef\", dln.\"BaseEntry\" \r\nfrom test.DLN1 dln, test.OITM oitm, test.ORDR ordr, Test.ODLN odln \r\nwhere odln.\"DocEntry\" = dln.\"DocEntry\" and odln.\"DocStatus\" = 'O' and ordr.\"DocEntry\" = dln.\"BaseEntry\" and ordr.\"U_Agent\" = '{empId}' and oitm.\"ItemCode\" = dln.\"ItemCode\";");
            //recordset.DoQuery($"select odln.\"DocEntry\", oitm.\"ItemCode\", oitm.\"ItemName\", oitm.\"PicturName\", dln.\"Quantity\", dln.\"Price\", ordr.\"DocNum\", dln.\"BaseRef\", dln.\"BaseEntry\" \r\nfrom test.DLN1 dln, test.OITM oitm, test.ORDR ordr, Test.ODLN odln \r\nwhere odln.\"DocEntry\" = dln.\"DocEntry\" \r\nand (odln.\"DocStatus\" = 'O'\tor (odln.\"DocStatus\" = 'C' and odln.\"GroupNum\" in (5,1,2,3,4,6,7)  and 'O' = (select oinv.\"DocStatus\" from Test.OINV oinv where oinv.\"CANCELED\" = 'N' and oinv.\"DocStatus\" = 'O'  and oinv.\"DocEntry\" in (select distinct(inv.\"DocEntry\")  from Test.inv1 inv  where inv.\"BaseEntry\" = odln.\"DocEntry\"  )))) and ordr.\"DocEntry\" = dln.\"BaseEntry\" and ordr.\"U_Agent\" = \'{empId}\' and oitm.\"ItemCode\" = dln.\"ItemCode\"");
            List<DeliveryItem> listItems = new List<DeliveryItem>();

            if (recordset.RecordCount == 0)
            {
                return listItems;
            }

            while (!recordset.EoF)
            {
                DeliveryItem deliveryItem = new DeliveryItem()
                {
                    ItemCode = recordset.Fields.Item("ItemCode").Value,
                    ItemName = recordset.Fields.Item("ItemName").Value,
                    Price = (double)recordset.Fields.Item("Price").Value,
                    Quantity = (int)recordset.Fields.Item("Quantity").Value,
                    PicturName = recordset.Fields.Item("PicturName").Value,
                    DocNum = recordset.Fields.Item("DocNum").Value,
                    BaseRef = recordset.Fields.Item("BaseRef").Value,
                    BaseEntry = recordset.Fields.Item("BaseEntry").Value,
                    DocEntry = (int)recordset.Fields.Item("DocEntry").Value
                };
                listItems.Add(deliveryItem);
                recordset.MoveNext();
            }
            return listItems;
        }

        public int CreateMerchVisit(CustomMerch customMerch)
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"SELECT test.\"MERCH_VISIT\".nextval as \"NEXTVAL\", cm.* FROM \"TEST\".\"@CUSTOM_MERCH\" cm limit 1");
            int newId = (int)recordset.Fields.Item("NEXTVAL").Value;

            recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"insert into \"TEST\".\"@CUSTOM_MERCH\" values({newId},'{customMerch.Name}',{newId},{customMerch.EmpID},'{customMerch.Created}','{customMerch.CardCode}','{customMerch.Comment}')");
            return newId;
        }
        public List<CustomMerch> GetMerchVisit(int empId)
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"SELECT  * FROM \"TEST\".\"@CUSTOM_MERCH\"");
            List<CustomMerch> listCustomMerch = new List<CustomMerch>();

            if (recordset.RecordCount == 0)
            {
                return listCustomMerch;
            }

            while (!recordset.EoF)
            {
                CustomMerch customMerch = new CustomMerch()
                {
                    Name = recordset.Fields.Item("Name").Value,
                    Code = recordset.Fields.Item("Code").Value,
                    VisitId = (int)recordset.Fields.Item("U_VisitId").Value,
                    Created = recordset.Fields.Item("U_Created").Value,
                    CardCode = recordset.Fields.Item("U_CardCode").Value,
                    Comment = recordset.Fields.Item("U_Comment").Value,
                    EmpID = (int)recordset.Fields.Item("U_EmpID").Value,
                };
                listCustomMerch.Add(customMerch);
                recordset.MoveNext();
            }
            return listCustomMerch;
        }

        public int CustomMerchVIVI ()
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"SELECT max(\"U_visitId\") as MAXVISITID FROM \"TEST\".\"@CUSTOM_MERCH\"");
            
            if (recordset.RecordCount == 0)
            {
                return 0;
            }

            return (int)recordset.Fields.Item("MAXVISITID").Value;
     
        }
        public List<MerchGroup> GetMerchListGroup()
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select \"Code\",\"Name\",\"U_GroupId\",\"U_Description\",\"U_GroupName\" from \"TEST\".\"@MERCH_GROUP\"");
            List<MerchGroup> listMerchGroup = new List<MerchGroup>();
            if (recordset.RecordCount == 0)
            {
                return listMerchGroup;
            }

            while (!recordset.EoF)
            {
                MerchGroup merchGroup = new MerchGroup()
                {

                    Name = recordset.Fields.Item("Name").Value,
                    Code = recordset.Fields.Item("Code").Value,
                    GroupId = (int)recordset.Fields.Item("U_GroupId").Value,
                    Description = recordset.Fields.Item("U_Description").Value,
                    GroupName = recordset.Fields.Item("U_GroupName").Value,

                };
                listMerchGroup.Add(merchGroup);
                recordset.MoveNext();
            }
            return listMerchGroup;
        }
        public string CreateGroupScore(GroupScore groupScore)
        {
            try
            {
                Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
                recordset.DoQuery($"SELECT test.\"MERCH_GR_SCORE_ID\".nextval as \"NEXTVAL\", cm.* FROM \"TEST\".\"@MERCH_GROUP_SCORE\" cm limit 1");
                int newId = (int)recordset.Fields.Item("NEXTVAL").Value;

                recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
                recordset.DoQuery($"insert into \"TEST\".\"@MERCH_GROUP_SCORE\" values('{newId}','{groupScore.Name}',{groupScore.VisitId},{groupScore.GroupId},{newId})");
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string CreateSkuScore(SkuScore skuScore)
        {
            try
            {
                Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
                recordset.DoQuery($"SELECT test.\"MERCH_SKU_SCORE_ID\".nextval as \"NEXTVAL\", cm.* FROM \"TEST\".\"@MERCH_SKU_SCORE\" cm limit 1");
                int newId = (int)recordset.Fields.Item("NEXTVAL").Value;

                recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
                recordset.DoQuery($"insert into \"TEST\".\"@MERCH_SKU_SCORE\" values('{newId}','{skuScore.Name}',{skuScore.VisitId},'{skuScore.ItemCode}',{newId})");
                return "0";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public ORDR GetSapOrderByDocEntry(int docEntry)
        {
            ORDR order = new ();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select \"DocEntry\", \r\n\"DocNum\", \r\n\"DocStatus\", \r\n\"DocDate\",\r\n\"DocTime\", \r\n\"CardCode\", \r\n\"CardName\", \r\n\"DocTotal\", \r\n\"GrosProfit\", \r\n\"OwnerCode\" ,\r\n\"GroupNum\",\r\n(CASE WHEN \"GroupNum\"='-1' THEN 'Cash'\r\n  WHEN \"GroupNum\"='1' OR \"GroupNum\"='2' OR \"GroupNum\"='3' OR \"GroupNum\"='4'  THEN 'Credit'\r\n  WHEN \"GroupNum\"='5' THEN 'Bank'\r\n  WHEN \"GroupNum\"='6' THEN 'Consignment'\r\n  END) AS \"PayType\" ,\"U_Agent\", \"U_Supervisor\" from TEST.ORDR where \"DocStatus\" = 'O' and \"DocEntry\" = {docEntry} limit 1;");
            
            if (recordset.RecordCount == 0)
            {
                return order;
            }
            
            order = new ORDR()
            {
                DocEntry = (int)recordset.Fields.Item("DocEntry").Value,
                DocNum = recordset.Fields.Item("DocNum").Value,
                DocStatus = recordset.Fields.Item("DocStatus").Value,
                DocDate = ConcateDodate(recordset.Fields.Item("DocDate").Value, recordset.Fields.Item("DocTime").Value),
                CardCode = recordset.Fields.Item("CardCode").Value,
                CardName = recordset.Fields.Item("CardName").Value,
                DocTotal = (double)recordset.Fields.Item("DocTotal").Value,
                GrosProfit = (double)recordset.Fields.Item("GrosProfit").Value,
                OwnerCode = (int)recordset.Fields.Item("OwnerCode").Value,
                GroupNum = (int)recordset.Fields.Item("GroupNum").Value,
                PayType = recordset.Fields.Item("PayType").Value,
                U_Agent = recordset.Fields.Item("U_Agent").Value,
                U_Supervisor = recordset.Fields.Item("U_Supervisor").Value,
            };
              
            return order;
        }

        public int GetExpeditorByRoot(int empId)
        {
            int empIdExpeditor = 0;

            string rootName = GetRootByEmployeByCode(empId);

            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select \tohem.\"empID\" from test.OHEM ohem left join test.hem6 hem on hem.\"empID\" = ohem.\"empID\" left join test.HTM1 htm on ohem.\"empID\" = htm.\"empID\" left join test.OHTM ohtm on htm.\"teamID\" = ohtm.\"teamID\" where hem.\"roleID\" = 4 and ohtm.\"name\" = '{rootName}' limit 1;");

            if (recordset.RecordCount == 1)
            {
                recordset.MoveFirst();
                empIdExpeditor = recordset.Fields.Item("empID").Value;
            }

            return empIdExpeditor;
        }

        public int GetSupervisorByRoot(int empId)
        {
            int empIdSupervisor = 0;

            string rootName = GetRootByEmployeByCode(empId);

            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            //recordset.DoQuery($"select distinct(ohem.\"manager\") as manager from  test.OHEM ohem  left join test.hem6 hem on hem.\"empID\" = ohem.\"empID\" left join test.HTM1 htm on ohem.\"empID\" = htm.\"empID\" left join test.OHTM ohtm on htm.\"teamID\" = ohtm.\"teamID\" where  hem.\"roleID\" in (1,8,9,10,11) and ohtm.\"name\" = '{rootName}' group by ohem.\"manager\" having ohem.\"manager\">0 limit 1;");
            recordset.DoQuery(Resource.SqlGetSupervisorByRoot.Replace("rootName",rootName));

            if (recordset.RecordCount == 1)
            {
                recordset.MoveFirst();
                empIdSupervisor = recordset.Fields.Item("manager").Value;
            }

            return empIdSupervisor;
        }

        public List<ORDR> GetListAllCanceledSapOrders()
        {
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select \"DocEntry\", \r\n\"DocNum\", \r\n\"DocStatus\", \r\n\"DocDate\",\r\n\"DocTime\", \r\n\"CardCode\", \r\n\"CardName\", \r\n\"DocTotal\", \r\n\"GrosProfit\", \r\n\"OwnerCode\" ,\r\n\"GroupNum\",\r\n(CASE WHEN \"GroupNum\"='-1' THEN 'Cash'\r\n  WHEN \"GroupNum\"='1' OR \"GroupNum\"='2' OR \"GroupNum\"='3' OR \"GroupNum\"='4'  THEN 'Credit'\r\n  WHEN \"GroupNum\"='5' THEN 'Bank'\r\n  WHEN \"GroupNum\"='6' THEN 'Consignment'\r\n  END) AS \"PayType\",\r\n\"Comments\" from TEST.ORDR where ordr.\"CANCELED\" = \'Y\'	and ordr.\"DocDate\" > add_days(current_date, -1);");
            List<ORDR> ORDRlist = new List<ORDR>();

            if (recordset.RecordCount == 0)
            {
                return ORDRlist;
            }

            while (!recordset.EoF)
            {
                ORDR oRDR = new ORDR()
                {
                    DocEntry = (int)recordset.Fields.Item("DocEntry").Value,
                    DocNum = recordset.Fields.Item("DocNum").Value,
                    DocStatus = recordset.Fields.Item("DocStatus").Value,
                    DocDate = ConcateDodate(recordset.Fields.Item("DocDate").Value, recordset.Fields.Item("DocTime").Value),
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    DocTotal = (double)recordset.Fields.Item("DocTotal").Value,
                    GrosProfit = (double)recordset.Fields.Item("GrosProfit").Value,
                    OwnerCode = (int)recordset.Fields.Item("OwnerCode").Value,
                    GroupNum = (int)recordset.Fields.Item("GroupNum").Value,
                    PayType = recordset.Fields.Item("PayType").Value,
                    Comments = recordset.Fields.Item("Comments").Value
                };
                ORDRlist.Add(oRDR);
                recordset.MoveNext();
            }
            return ORDRlist;
        }

        public List<DaylyReportKassaLines> GetDeylyReportKassa(DateTime fromDate, DateTime toDate, string kassa)
        {
            List<DaylyReportKassaLines> reportLines = new List<DaylyReportKassaLines>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlDeylyKassa.Replace("KASSA",$"\'{kassa}\'").Replace("FROMDATE",$"\'{fromDate.Date}\'").Replace("TODATE",$"\'{toDate.Date}\'"));

            if (recordset.RecordCount == 0)
            {
                return reportLines;
            }

            while (!recordset.EoF)
            {
                DaylyReportKassaLines line = new DaylyReportKassaLines()
                {
                    AccountablePerson = recordset.Fields.Item("Name").Value,
                    Coming = (double)recordset.Fields.Item("CashSum").Value,
                    Credits = (double)recordset.Fields.Item("CreditSum").Value,
                    Bank = (double)recordset.Fields.Item("Bank").Value,
                    Consignment = (double)recordset.Fields.Item("Consignment").Value,
                    Refund = 0,
                    Expense = (double)recordset.Fields.Item("raschod").Value,
                    Transfer = (double)recordset.Fields.Item("perevod").Value,
                    Total = (double)recordset.Fields.Item("DocTotal").Value
                };
                reportLines.Add(line);
                recordset.MoveNext();
            }
            
            return reportLines;
        }

        public DaylyReportKassa GetKassaStartEndDay(DateTime fromDate, DateTime toDate, string kassa)
        {
            DaylyReportKassa dayleReport = new DaylyReportKassa();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string query = Resource.KassaStartDayEndDay.Replace("KASSA", $"\'{kassa}\'").Replace("FROMDAY", $"\'{fromDate.Date}\'").Replace("TODATE", $"\'{toDate.Date}\'");
            recordset.DoQuery(query);

            if (recordset.RecordCount == 0)
            {
                return dayleReport;
            }

            while (!recordset.EoF)
            {
                dayleReport.KassaStartDay = (double)recordset.Fields.Item("startday").Value;
                dayleReport.KassaEndDay = (double)recordset.Fields.Item("endday").Value;
                dayleReport.KassaComming = (double)recordset.Fields.Item("comming").Value;
                dayleReport.KassaExpense = (double)recordset.Fields.Item("expense").Value;
                dayleReport.KassaTransactions = (double)recordset.Fields.Item("transct").Value;
                recordset.MoveNext();
            }
            return dayleReport;
        }

        public List<CashAccount> GetListCashAccounts()
        {
            List<CashAccount> reportLines = new List<CashAccount>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery("select distinct(\"CashAcct\") as \"CashAcct\" from test.orct where \"Canceled\" = 'N';");

            if (recordset.RecordCount == 0)
            {
                return reportLines;
            }

            while (!recordset.EoF)
            {
                CashAccount line = new CashAccount()
                {
                    CashAcc = recordset.Fields.Item("CashAcct").Value,
                };
                reportLines.Add(line);
                recordset.MoveNext();
            }

            return reportLines;
        }

        public List<ErrorOrct> GetListOrctErrors()
        {
            List<ErrorOrct> reportLines = new List<ErrorOrct>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery("select \"DocNum\", \"DocDate\", \"CardName\",\t\"CashAcct\",\t\"CashSum\" from test.orct where \"NoDocSum\" > 0 and \"Canceled\" = 'N';");

            if (recordset.RecordCount == 0)
            {
                return reportLines;
            }

            while (!recordset.EoF)
            {
                ErrorOrct line = new ErrorOrct()
                {
                    DocNum = recordset.Fields.Item("DocNum").Value,
                    DocDate = recordset.Fields.Item("DocDate").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    CashAcct = recordset.Fields.Item("CashAcct").Value,
                    Cashsum = (double)recordset.Fields.Item("CashSum").Value
                };
                reportLines.Add(line);
                recordset.MoveNext();
            }

            return reportLines;
        }

        public List<OkReportLines> GetOkReport(DateTime fromDate, DateTime toDate)
        {
            List<OkReportLines> reportLines = new List<OkReportLines>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlOkReport.Replace("FROMDATE", $"\'{fromDate.Date}\'").Replace("TODATE", $"\'{toDate.Date}\'"));

            if (recordset.RecordCount == 0)
            {
                return reportLines;
            }

            while (!recordset.EoF)
            {
                OkReportLines line = new OkReportLines()
                {
                    DocDate = recordset.Fields.Item("DocDate").Value,
                    SumZakaza = (double)recordset.Fields.Item("SumZakaza").Value,
                    SumProdaji = (double)recordset.Fields.Item("SumProdaji").Value,
                    SumOplaty = (double)recordset.Fields.Item("SumOplaty").Value,
                    SumVozvrat = (double)recordset.Fields.Item("SumVozvrat").Value,
                };
                reportLines.Add(line);
                recordset.MoveNext();
            }

            return reportLines;
        }




        public List<OkReportDetals> GetOkReportDeteils(DateTime fromDate)
        {
            List<OkReportDetals> reportDeteils = new List<OkReportDetals>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlOkReportDetails.Replace("FROMDATE", $"\'{fromDate.Date}\'").Replace("TODATE", $"\'{fromDate.Date}\'"));

            if (recordset.RecordCount == 0)
            {
                return reportDeteils;
            }

            while (!recordset.EoF)
            {
                OkReportDetals line = new OkReportDetals()
                {
                    DocEntry = recordset.Fields.Item("DocEntry").Value,
                    DocNum = recordset.Fields.Item("DocNum").Value,
                    DocDate = recordset.Fields.Item("DocDate").Value,
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    SumZakaza = (double)recordset.Fields.Item("SumZakaza").Value,
                    SumProdaji = (double)recordset.Fields.Item("SumProdaji").Value,
                    SumOplaty = (double)recordset.Fields.Item("SumOplaty").Value,
                    SumVozvrat = (double)recordset.Fields.Item("SumVozvrat").Value,
                };
                reportDeteils.Add(line);
                recordset.MoveNext();
            }

            return reportDeteils;
        }

        public List<CreditReportLines> GetCreditReportLines(DateTime fromDate , DateTime toDate, string root)
        {
            List<CreditReportLines> reportDeteils = new List<CreditReportLines>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string replase = "";
            if (root.ToLower() == "ashgabad")
            {
                replase = "a.\"territoty\" = 134";
            }
            else
            {
                replase = "a.\"route\" like ROOT".Replace("ROOT", $"\'{root}\'");
            }

            recordset.DoQuery(Resource.SqlCreditReport.Replace("FROMDATE", $"\'{fromDate.Date}\'").Replace("TODATE", $"\'{toDate.Date}\'").Replace("XXXX", $"{replase}"));

            if (recordset.RecordCount == 0)
            {
                return reportDeteils;
            }

            while (!recordset.EoF)
            {
                CreditReportLines line = new CreditReportLines()
                {
                    Route = recordset.Fields.Item("route").Value,
                    Agent = recordset.Fields.Item("agent").Value,
                    DocNum = recordset.Fields.Item("docNum").Value,
                    DeliveriDate = recordset.Fields.Item("deliveryDate").Value,
                    Client = recordset.Fields.Item("client").Value,
                    Credit7 = (double)recordset.Fields.Item("credit7").Value,
                    Credit14 = (double)recordset.Fields.Item("credit14").Value,
                    Credit30 = (double)recordset.Fields.Item("credit30").Value,
                    Ostalos = (int)recordset.Fields.Item("ostalos").Value,
                    Expired = (int)recordset.Fields.Item("expired").Value,
                    Balance = (double)recordset.Fields.Item("balance").Value,
                    Transfer = (double)recordset.Fields.Item("transfer").Value,
                    CreditSum = (double)recordset.Fields.Item("creditSum").Value,
                    ConsignmentTotal = (double)recordset.Fields.Item("consignment").Value,
                    SumOplaty = (double)recordset.Fields.Item("sumOplaty").Value,
                    SumVozvrat = (double)recordset.Fields.Item("SumVozvrat").Value,
                    OrderSum = (double)recordset.Fields.Item("orderSum").Value
                };
                reportDeteils.Add(line);
                recordset.MoveNext();
            }

            return reportDeteils;
        }


        public List<URouteID> GetURouteID(string region)
        {
            List<URouteID> uRouteID = new List<URouteID>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlURouteID.Replace("XX", region));

            if (recordset.RecordCount == 0)
            {
                return uRouteID;
            }

            while (!recordset.EoF)
            {
                URouteID line = new URouteID()
                {
                    RouteId = recordset.Fields.Item("URouteID").Value
                };
                uRouteID.Add(line);
                recordset.MoveNext();
            }
            uRouteID.Add(new URouteID() { RouteId = "Ashgabad" });

            return uRouteID;
        }

        

        public List<List<Percent>> GetPercentAgent(DateTime fromDate, DateTime toDate)
        {
            List<List<Percent>> percents = new List<List<Percent>>();
            List<Percent> percentLinesSupervisors = new List<Percent>();
            List<Percent> percentLinesDelivery = new List<Percent>();
            List<Percent> percentLinesAgent = new List<Percent>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlPercentSupervisors.Replace("FROMDATE", $"\'{fromDate.Date}\'").Replace("TODATE", $"\'{toDate.Date}\'"));

            if (recordset.RecordCount == 0)
            {
                return percents;
            }

            while (!recordset.EoF)
            {
                Percent line = new Percent()
                {
                    JopTitle = recordset.Fields.Item("jopTitle").Value,
                    Code = (string)recordset.Fields.Item("code").Value,
                    Name = recordset.Fields.Item("Name").Value,
                    Sum = recordset.Fields.Item("Sum").Value,
                    Commission = recordset.Fields.Item("commission").Value,
                };
                percentLinesSupervisors.Add(line);
                recordset.MoveNext();
            }
            percents.Add(percentLinesSupervisors);

            recordset.DoQuery(Resource.SqlPercentDelivery.Replace("FROMDATE", $"\'{fromDate.Date}\'").Replace("TODATE", $"\'{toDate.Date}\'"));

            if (recordset.RecordCount == 0)
            {
                return percents;
            }

            while (!recordset.EoF)
            {
                Percent line = new Percent()
                {
                    JopTitle = recordset.Fields.Item("jopTitle").Value,
                    Code = recordset.Fields.Item("code").Value.ToString(),
                    Name = recordset.Fields.Item("Name").Value,
                    Sum = recordset.Fields.Item("Sum").Value,
                    Commission = recordset.Fields.Item("commission").Value,
                };
                percentLinesDelivery.Add(line);
                recordset.MoveNext();
            }
            percents.Add(percentLinesDelivery);

            recordset.DoQuery(Resource.SqlPercentAgent.Replace("FROMDATE", $"\'{fromDate.Date}\'").Replace("TODATE", $"\'{toDate.Date}\'"));

            if (recordset.RecordCount == 0)
            {
                return percents;
            }

            while (!recordset.EoF)
            {
                Percent line = new Percent()
                {
                    JopTitle = recordset.Fields.Item("jopTitle").Value,
                    Code = recordset.Fields.Item("code").Value.ToString(),
                    Name = recordset.Fields.Item("Name").Value,
                    Sum = recordset.Fields.Item("Sum").Value,
                    Commission = recordset.Fields.Item("commission").Value,
                };
                percentLinesAgent.Add(line);
                recordset.MoveNext();
            }
            percents.Add(percentLinesAgent);

            return percents;
        }

        public List<PercentDeliveryAgent> GetPerecentDetailsSupervisor(DateTime fromDate , DateTime toDate, string code)
        {
            List<PercentDeliveryAgent> reportDeteils = new List<PercentDeliveryAgent>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string test = Resource.SqlPercentDetailsSupervisors.Replace("FROMDATE", $"\'{fromDate.Date}\'").Replace("TODATE", $"\'{toDate.Date}\'").Replace("XXXX", $"\'{code}\'");
            recordset.DoQuery(test);

            if (recordset.RecordCount == 0)
            {
                return reportDeteils;
            }

            while (!recordset.EoF)
            {
                PercentDeliveryAgent line = new PercentDeliveryAgent()
                {
                    DocEntry = recordset.Fields.Item("DocEntry").Value,
                    Code = recordset.Fields.Item("Root").Value,
                    Name = recordset.Fields.Item("Name").Value,
                    Sum = recordset.Fields.Item("Sum").Value,
                    DocDate = recordset.Fields.Item("Date").Value,
                    DocNum= recordset.Fields.Item("DocNum").Value,
                    CardCode = recordset.Fields.Item("CardCode").Value,
                };
                reportDeteils.Add(line);
                recordset.MoveNext();
            }

            return reportDeteils;
        }

            
        public List<PercentDeliveryAgent> GetPerecentDetailsDeliveryAgent(DateTime fromDate, DateTime toDate, string code)
        {
            List<PercentDeliveryAgent> reportDeteils = new List<PercentDeliveryAgent>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlPercentDetailsDelivery.Replace("FROMDATE", $"\'{fromDate.Date}\'").Replace("TODATE", $"\'{toDate.Date}\'").Replace("XXXX", $"\'{code}\'"));

            if (recordset.RecordCount == 0)
            {
                return reportDeteils;
            }

            while (!recordset.EoF)
            {
                PercentDeliveryAgent line = new PercentDeliveryAgent()
                {
                    DocEntry = recordset.Fields.Item("DocEntry").Value,
                    Code = recordset.Fields.Item("code").Value.ToString(),
                    Name = recordset.Fields.Item("Name").Value,
                    Sum = recordset.Fields.Item("Sum").Value,
                    DocDate = recordset.Fields.Item("Date").Value,
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    DocNum = recordset.Fields.Item("DocNum").Value,
                };
                reportDeteils.Add(line);
                recordset.MoveNext();
            }

            return reportDeteils;
        }

        public List<PercentDeliveryAgent> GetPerecentDetailsAgent(DateTime fromDate, DateTime toDate, string code)
        {
            List<PercentDeliveryAgent> reportDeteils = new List<PercentDeliveryAgent>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlPrecentDetailsAgent_.Replace("FROMDATE", $"\'{fromDate.Date}\'").Replace("TODATE", $"\'{toDate.Date}\'").Replace("XXXX", $"\'{code}\'"));

            if (recordset.RecordCount == 0)
            {
                return reportDeteils;
            }

            while (!recordset.EoF)
            {
                PercentDeliveryAgent line = new PercentDeliveryAgent()
                {
                    DocEntry = recordset.Fields.Item("DocEntry").Value,
                    Code = recordset.Fields.Item("code").Value.ToString(),
                    Name = recordset.Fields.Item("Name").Value,
                    Sum = recordset.Fields.Item("Sum").Value,
                    DocDate = recordset.Fields.Item("Date").Value,
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    DocNum = recordset.Fields.Item("DocNum").Value,
                };
                reportDeteils.Add(line);
                recordset.MoveNext();
            }

            return reportDeteils;
        }

        public List<RDR1> GetListSapInvoiceLines(int docEntry)
        {
            List<RDR1> listRDR1 = new List<RDR1>();

            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select * from INV1 inv1 where inv1.\"DocEntry\" = {docEntry}");
            while (!recordset.EoF)
            {
                RDR1 _RDR1 = new RDR1()
                {
                    DocEntry = (int)recordset.Fields.Item("DocEntry").Value,
                    LineNum = (int)recordset.Fields.Item("LineNum").Value,
                    ItemCode = recordset.Fields.Item("ItemCode").Value,
                    Description = recordset.Fields.Item("Dscription").Value,
                    Quantity = (double)recordset.Fields.Item("Quantity").Value,
                    Price = (double)recordset.Fields.Item("Price").Value,
                    LineTotal = (double)recordset.Fields.Item("LineTotal").Value,
                    WhsCode = recordset.Fields.Item("WhsCode").Value
                };
                listRDR1.Add(_RDR1);
                recordset.MoveNext();
            }

            return listRDR1;
        }
        public List<Сonsignment> GetСonsignment(DateTime fromDate, DateTime toDate, string code)
        {
            List<Сonsignment> reportDeteils = new List<Сonsignment>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string query = Resource.SqlСonsignmentReport.Replace("FROMDATE", $"\'{fromDate.Date}\'").Replace("TODATE", $"\'{toDate.Date}\'").Replace("XXXX", $"\'{code}\'");
            recordset.DoQuery(query);

            if (recordset.RecordCount == 0)
            {
                return reportDeteils;
            }

            while (!recordset.EoF)
            {
                Сonsignment line = new Сonsignment()
                {
                    IdReceipts = (int)recordset.Fields.Item("IdReceipts").Value,
                    ReceiptNumber = (int)recordset.Fields.Item("ReceiptNumber").Value,
                    ReceiptDate = recordset.Fields.Item("ReceiptDate").Value,
                    ProductCode = recordset.Fields.Item("ProductCode").Value,
                    ProductName = recordset.Fields.Item("ProductName").Value,
                    QuantityAtStart = (int)recordset.Fields.Item("QuantityAtStart").Value,
                    ReceiptsPeriod = (int)recordset.Fields.Item("ReceiptsPeriod").Value,
                    ReturnsPeriod = (int)recordset.Fields.Item("ReturnsPeriod").Value,
                    QuantityAtEnd = (int)recordset.Fields.Item("QuantityAtEnd").Value,
                    Sales = (int)recordset.Fields.Item("Sales").Value,
                    RecPrice = (double)recordset.Fields.Item("RecPrice").Value,
                    CommissionRemuneration = (double)recordset.Fields.Item("CommissionRemuneration").Value,
                    PaymentPrincipal = (double)recordset.Fields.Item("PaymentPrincipal").Value,
                    AdmissionPrice = (double)recordset.Fields.Item("AdmissionPrice").Value,
                    StartingAmountArrivalPrice = (double)recordset.Fields.Item("StartingAmountArrivalPrice").Value,
                    StartingAmountPriceDetails = (double)recordset.Fields.Item("StartingAmountPriceDetails").Value,
                    ReceiptAmountArrivalPrice = (double)recordset.Fields.Item("ReceiptAmountArrivalPrice").Value,
                    ReceiptAmountRecommendedPrice = (double)recordset.Fields.Item("ReceiptAmountRecommendedPrice").Value,
                    AmountEndEntryPrice = (double)recordset.Fields.Item("AmountEndEntryPrice").Value,
                    AmountEndSellingPrice = (double)recordset.Fields.Item("AmountEndSellingPrice").Value
                };
                reportDeteils.Add(line);
                recordset.MoveNext();
            }

            return reportDeteils;
        }

        public List<PrepaymentReport> GetPrepaymentReport(DateTime fromDate, DateTime toDate)
        {
            List<PrepaymentReport> reportDeteils = new List<PrepaymentReport>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string query = Resource.SqlPrepaymentReport.Replace("FROMDATE", $"\'{fromDate.Date}\'").Replace("TODATE", $"\'{toDate.Date}\'");
            recordset.DoQuery(query);

            if (recordset.RecordCount == 0)
            {
                return reportDeteils;
            }

            while (!recordset.EoF)
            {
                PrepaymentReport line = new PrepaymentReport()
                {
                    DocNum = (int)recordset.Fields.Item("DocNum").Value,
                    DocDate = recordset.Fields.Item("DocDate").Value,
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    DocTotal = (double)recordset.Fields.Item("DocTotal").Value,
                    Name = recordset.Fields.Item("Name").Value
                };
                reportDeteils.Add(line);
                recordset.MoveNext();
            }

            return reportDeteils;
        }

        public List<ConsigmentClient> GetConsigmentClient()
        {
            List<ConsigmentClient> reportDeteils = new List<ConsigmentClient>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string query = Resource.SqlConsignmentClient;
            recordset.DoQuery(query);

            if (recordset.RecordCount == 0)
            {
                return reportDeteils;
            }

            while (!recordset.EoF)
            {
                ConsigmentClient line = new ConsigmentClient()
                {

                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,

                };
                reportDeteils.Add(line);
                recordset.MoveNext();
            }

            return reportDeteils;
        }

        public List<LoadingReport> GetLoadingWarehouseReport(DateTime fromDate, string empID)
        {
            List<LoadingReport> loadingReport = new List<LoadingReport>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string query = Resource.SqlItemsForLoading.Replace("FROM", $"\'{fromDate.Date}\'").Replace("AGENT", $"\'{empID}\'");
            recordset.DoQuery(query);

            if (recordset.RecordCount == 0)
            {
                return loadingReport;
            }

            while (!recordset.EoF)
            {
                LoadingReport line = new LoadingReport()
                {
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    Description = recordset.Fields.Item("Dscription").Value,
                    CodeBars = recordset.Fields.Item("CodeBars").Value,
                    Quantity = (int)recordset.Fields.Item("Quantity").Value,
                    ShipDate = recordset.Fields.Item("ShipDate").Value,
                    Price = (double)recordset.Fields.Item("Price").Value,
                    U_Agent = (int)recordset.Fields.Item("U_Agent").Value,
                    DocDate = recordset.Fields.Item("DocDate").Value,
                    DocDueDate = recordset.Fields.Item("DocDueDate").Value,
                };
                loadingReport.Add(line);
                recordset.MoveNext();
            }

            return loadingReport;
        }

        public List<ForwarderDocList> GetForwarderDocReport(DateTime fromDate, string empID)
        {
            List<ForwarderDocList> loadingReport = new List<ForwarderDocList>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string query = Resource.SqlExpeditorDocList.Replace("FROMDATE", $"\'{fromDate.Date}\'").Replace("AGENT", $"\'{empID}\'");
            recordset.DoQuery(query);

            if (recordset.RecordCount == 0)
            {
                return loadingReport;
            }

            while (!recordset.EoF)
            {
                ForwarderDocList line = new ForwarderDocList()
                {
                    DocNum = (int)recordset.Fields.Item("DocNum").Value,
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    RouteID = recordset.Fields.Item("U_RouteID").Value,
                    Name = recordset.Fields.Item("Name").Value,
                    Mobile = recordset.Fields.Item("mobile").Value,
                    DocTotal = (double)recordset.Fields.Item("DocTotal").Value,
                    PayType = recordset.Fields.Item("PayType").Value,
                    PayTypeForSum = recordset.Fields.Item("PayTypeForSum").Value
                };
                loadingReport.Add(line);
                recordset.MoveNext();
            }

            return loadingReport;
        }
        public List<WarehousesSapGet> GetWarehousesSap()
        {
            List<WarehousesSapGet> warehouses = new List<WarehousesSapGet>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string query = Resource.SqlWarehouses;
            recordset.DoQuery(query);

            if (recordset.RecordCount == 0)
            {
                return warehouses;
            }

            while (!recordset.EoF)
            {
                WarehousesSapGet line = new WarehousesSapGet()
                {
                    WhsCode = recordset.Fields.Item("WhsCode").Value,
                };
                warehouses.Add(line);
                recordset.MoveNext();
            }

            return warehouses;
        }

        public List<SqlProductGroup> GetProductGroup()
        {
            List<SqlProductGroup> productgroup = new List<SqlProductGroup>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string query = Resource.SqlProductGroupName;
            recordset.DoQuery(query);

            if (recordset.RecordCount == 0)
            {
                return productgroup;
            }

            while (!recordset.EoF)
            {
                SqlProductGroup line = new SqlProductGroup()
                {
                    ItmsGrpCod = recordset.Fields.Item("ItmsGrpCod").Value,
                    ItmsGrpNam = recordset.Fields.Item("ItmsGrpNam").Value
                };
                productgroup.Add(line);
                recordset.MoveNext();
            }

            return productgroup;
        }

        public List<WarehouseWithdrawal> GetWarehouseWithdrawalSql( string? stock, string? idproductGroup, string? response)
        {
            List<WarehouseWithdrawal> withdrawal = new List<WarehouseWithdrawal>();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string replasestock = "";
            string replaseidproductGroup = "";
            if (stock != null || idproductGroup != null)
            {
                if (stock != null && idproductGroup == null)
                {
                    replasestock = $"and oitw.\"WhsCode\" = \'{stock}\' ";
                }
                else if (stock == null && idproductGroup != null)
                {
                    replaseidproductGroup = $"and oitm.\"ItmsGrpCod\" = {idproductGroup} ";
                } 
                else if (stock != null && idproductGroup != null) 
                {
                    replasestock = $"and oitw.\"WhsCode\" = \'{stock}\' ";
                   replaseidproductGroup = $"and oitm.\"ItmsGrpCod\" = {idproductGroup} ";
                }
            }
            else 
            {
                
            }
            if (response != null) { response += ")"; }
            string query = Resource.SqlWarehouseWithdrawal.Replace("replaseidproductGroup", $"{replaseidproductGroup}").Replace("replasestock", $"{replasestock}").Replace("response", $"{response}");
            recordset.DoQuery(query);

            if (recordset.RecordCount == 0)
            {
                return withdrawal;
            }

            while (!recordset.EoF)
            {
                WarehouseWithdrawal line = new WarehouseWithdrawal()
                {
                    ItemCode = recordset.Fields.Item("ItemCode").Value,
                    ItemName = recordset.Fields.Item("ItemName").Value,
                    OnHand = recordset.Fields.Item("OnHand").Value,
                    IsCommited = recordset.Fields.Item("IsCommited").Value,
                    OnOrder = recordset.Fields.Item("OnOrder").Value
                };
                withdrawal.Add(line);
                recordset.MoveNext();
            }

            return withdrawal;
        }
        
        public List<ProductGroupsPropertiesSql> GetProductGroupsPropertiesSql()
        {
            List<ProductGroupsPropertiesSql> product = new();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select \"ItmsTypCod\" , \"ItmsGrpNam\" from test.oitg");

            if (recordset.RecordCount == 0)
            {
                return product;
            }

            while (!recordset.EoF)
            {
                ProductGroupsPropertiesSql line = new ProductGroupsPropertiesSql()
                {
                    ItmsTypCod = recordset.Fields.Item("ItmsTypCod").Value,
                    ItmsGrpNam = recordset.Fields.Item("ItmsGrpNam").Value
                };
            product.Add(line);
            recordset.MoveNext();
            }

            return product;
        }

        public List<OITB> GetItemGroupsListSql()
        {
            List<OITB> product = new();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.GetItemGroups);

            if (recordset.RecordCount == 0)
            {
                return product;
            }

            while (!recordset.EoF)
            {
                OITB line = new OITB()
                {
                    ItmsGrpCod = recordset.Fields.Item("ItmsGrpCod").Value,
                    ItmsGrpNam = recordset.Fields.Item("ItmsGrpNam").Value
                };
                product.Add(line);
                recordset.MoveNext();
            }

            return product;
        }

        public string GetWarehouseCode(string owner)
        {
            string rootName = "";
            string whsCode = "";
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlGetRootNameByEmpID.Replace("EMPID",owner));
            
            if (recordset.RecordCount == 0)
            {
                return whsCode;
            }

            while (!recordset.EoF)
            {
                rootName = recordset.Fields.Item("name").Value;
                
                recordset.MoveNext();
            }
            
            switch (rootName.Trim().ToUpper().Substring(rootName.Length-2,2))
            {
                case "AG": return "YALKYM";
                case "DZ": return "DASHOGUZ";
                case "MR": return "MARY";
                case "BN": return "BALKANAB";
                case "LB": return "LEBAP";
                case "KR": return "KERKI";
                case "TR": return "TURKMENB";
                case "TJ": return "TEJEN";
            }

            return "YALKYM";
        }

        public string GetCashAccount(string owner)
        {
            string rootName = "";
            string cashAccount = "";
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery(Resource.SqlGetRootNameByEmpID.Replace("EMPID", owner));

            if (recordset.RecordCount == 0)
            {
                return cashAccount;
            }

            while (!recordset.EoF)
            {
                rootName = recordset.Fields.Item("name").Value;

                recordset.MoveNext();
            }

            switch (rootName.Trim().ToUpper().Substring(rootName.Length - 2, 2))
            {
                case "AG": return "YALKYM";
                case "DZ": return "DASHOGUZ";
                case "MR": return "MARY";
                case "BN": return "BALKANAB";
                case "LB": return "LEBAP";
                case "KR": return "KERKI";
                case "TR": return "TURKMENB";
                case "TJ": return "TEJEN";
            }

            return "YALKYM";
        }

        public List<DeliveryForReport> GetDeliveryForReportSQL()
        {
            int docEntry;
            List<DeliveryForReport> product = new();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string query = Resource.SqlDeliveryForReport;
            recordset.DoQuery(query);

            if (recordset.RecordCount == 0)
            {
                return product;
            }

            while (!recordset.EoF)
            {
                DeliveryForReport line = new DeliveryForReport()
                {
                    DocEntry = recordset.Fields.Item("DocEntry").Value,
                    DocNum = recordset.Fields.Item("DocNum").Value,
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    DocDate = recordset.Fields.Item("DocDate").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    DocTotal = recordset.Fields.Item("DocTotal").Value,
                    Comments = recordset.Fields.Item("Comments").Value,
                    U_Agent = recordset.Fields.Item("U_Agent").Value,
                    U_Supervisor = recordset.Fields.Item("U_Supervisor").Value,
                    PymntGroup = recordset.Fields.Item("PymntGroup").Value,
                    NameAgent = recordset.Fields.Item("NameAgent").Value,
                    NameSupervisor = recordset.Fields.Item("NameSupervisor").Value,
                    deliveryForReportLens = GetDeliveryForReportLens((int)recordset.Fields.Item("DocEntry").Value)
                };
                product.Add(line);
                recordset.MoveNext();
            }
            
            return product;
        }
        public DeliveryForReportLens[] GetDeliveryForReportLens(int DocEntry)
        {
            List<DeliveryForReportLens> LensReport = new();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            recordset.DoQuery($"select \"DocEntry\", \"CodeBars\", \"ItemCode\", \"Dscription\", \"Quantity\", \"unitMsr\", \"Price\", \"LineTotal\", \"OpenSum\" from test.dln1 where \"DocEntry\" = {DocEntry}");

            if (recordset.RecordCount == 0)
            {
                return LensReport.ToArray();
            }

            while (!recordset.EoF)
            {
                DeliveryForReportLens line = new DeliveryForReportLens()
                {

                    DocEntry = recordset.Fields.Item("DocEntry").Value,
                    CodeBars = recordset.Fields.Item("CodeBars").Value,
                    ItemCode = recordset.Fields.Item("ItemCode").Value,
                    Dscription = recordset.Fields.Item("Dscription").Value,
                    Quantity = recordset.Fields.Item("Quantity").Value,
                    unitMsr = recordset.Fields.Item("unitMsr").Value,
                    Price = recordset.Fields.Item("Price").Value,
                    LineTotal = recordset.Fields.Item("LineTotal").Value,
                    OpenSum = recordset.Fields.Item("OpenSum").Value
                };
                LensReport.Add(line);
                recordset.MoveNext();
            }

            return LensReport.ToArray();
            
        }

        public List<DeliveryForReport> GetDeliveryForReportByRegion(string region)
        {
            int docEntry;
            List<DeliveryForReport> product = new();
            Recordset recordset = company.GetBusinessObject(BoObjectTypes.BoRecordset);
            string query = Resource.SqlGetDeliveryReportByRegion.Replace("REGION", region);
            recordset.DoQuery(query);

            if (recordset.RecordCount == 0)
            {
                return product;
            }

            while (!recordset.EoF)
            {
                DeliveryForReport line = new DeliveryForReport()
                {
                    DocEntry = recordset.Fields.Item("DocEntry").Value,
                    DocNum = recordset.Fields.Item("DocNum").Value,
                    CardCode = recordset.Fields.Item("CardCode").Value,
                    DocDate = recordset.Fields.Item("DocDate").Value,
                    CardName = recordset.Fields.Item("CardName").Value,
                    DocTotal = recordset.Fields.Item("DocTotal").Value,
                    Comments = recordset.Fields.Item("Comments").Value,
                    U_Agent = recordset.Fields.Item("U_Agent").Value,
                    U_Supervisor = recordset.Fields.Item("U_Supervisor").Value,
                    PymntGroup = recordset.Fields.Item("PymntGroup").Value,
                    NameAgent = recordset.Fields.Item("NameAgent").Value,
                    NameSupervisor = recordset.Fields.Item("NameSupervisor").Value,
                    deliveryForReportLens = GetDeliveryForReportLens((int)recordset.Fields.Item("DocEntry").Value)
                };
                product.Add(line);
                recordset.MoveNext();
            }

            return product;
        }
    }
}