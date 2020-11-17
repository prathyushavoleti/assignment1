using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary1
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICalculator" in both code and config file together.
    [ServiceContract]
    public interface ICalculator
    {
        [OperationContract]
        //void DoWork();
        int sum(int num1, int num2);
        [OperationContract]
        //void DoWork();
        int sub(int num1, int num2);
        [OperationContract]
        //void DoWork();
        int mul(int num1, int num2);
        [OperationContract]
        //void DoWork();
        int div(int num1, int num2);
        [OperationContract]
        int mod(int num1, int num2);
        [OperationContract]
        int even_odd(int num1);
        [OperationContract]
        string display(string str1, string str2);
       

    }

}
[DataContract]
public class compositetype
{
    bool boolvalue = true;
    string stringvalue = "hello world";
    [DataMember]
    public bool Boolvalue
    {
        get { return boolvalue; }
        set { boolvalue = value; }
    }
    public string stringValue
    {
        get { return stringvalue; }
        set { stringvalue = value; }
    }
}
