using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace RivicSystems_WcfServiceDemo
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IStudentService" in both code and config file together.
    [ServiceContract]
    public interface IStudentService
    {
        [OperationContract]
        string Enroll();

        [OperationContract]
        string RegisterForCourse(string courseId);

        [OperationContract]
        int GenerateException(int num1, int num2);
    }
}
