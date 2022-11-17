using UnitTestConsole;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Calculate_Teacher_Salary1()
        {
            Teacher t1 = new Teacher() { ID = 1, Name = "Ly", Factor = 1, UnionMember = false, Seniority = 5 };
            Assert.AreEqual(t1.GetSalary(), 6862.5);
        }

        [TestMethod]
        public void Calculate_Teacher_Salary2()
        {
            Teacher t2 = new Teacher() { ID = 2, Name = "Hue", Factor = 1.5, UnionMember = true, Seniority = 7 };
            Assert.AreEqual(t2.GetSalary(), 9765.8125);
        }

        [TestMethod]
        public void Calculate_Teacher_Salary3()
        {
            Teacher t3 = new Teacher() { ID = 3, Name = "Minh", Factor = 2.7, UnionMember = false, Seniority = 10 };
            Assert.AreEqual(t3.GetSalary(), 15028.75);
        }

        [TestMethod]
        public void Calculate_Teacher_Salary4()
        {
            Teacher t4 = new Teacher() { ID = 4, Name = "Nhan", Factor = 3.6, UnionMember = true, Seniority = 15 };
            Assert.AreEqual(t4.GetSalary(), 21637.95);
        }

        [TestMethod]
        public void Calculate_Researcher_Salary1()
        {
            Researcher r1 = new Researcher() { ID = 1, Name = "Ly", Factor = 1, UnionMember = false, NumOfPaper = 5, PaperRank = 4 };
            Assert.AreEqual(r1.GetSalary(), 50975.1);
        }

        [TestMethod]
        public void Calculate_Researcher_Salary2()
        {
            Researcher r2 = new Researcher() { ID = 2, Name = "Hue", Factor = 1.5, UnionMember = true, NumOfPaper = 7, PaperRank = 3 };
            Assert.AreEqual(r2.GetSalary(), 71512.65);
        }

        [TestMethod]
        public void Calculate_Researcher_Salary3()
        {
            Researcher r3 = new Researcher() { ID = 3, Name = "Minh", Factor = 2.7, UnionMember = false, NumOfPaper = 10, PaperRank = 6 };
            Assert.AreEqual(r3.GetSalary(), 102982.77);
        }

        [TestMethod]
        public void Calculate_Researcher_Salary4()
        {
            Researcher r4 = new Researcher() { ID = 4, Name = "Nhan", Factor = 3.6, UnionMember = true, NumOfPaper = 8, PaperRank = 2 };
            Assert.AreEqual(r4.GetSalary(), 401310.36);
        }
    }
}