using System;

namespace Casbin学习
{
    class Program
    {
        static void Main(string[] args)
        {
			e, _:= casbin.Enforcer("rbac_model.conf", "rbac.csv")


           // superAdmin
            if (e.Enforce("superAdmin", "project", "read"))
            { 
            }
		}
    }
}
