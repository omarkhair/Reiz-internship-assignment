using System.Collections;

class Branch
{
    private List<Branch> branches;

    public Branch(List<Branch> branches){
        this.branches = branches;
    }
    public Branch(){
        branches = new List<Branch>();
    }

    public void AddBranch(Branch branch){
        branches.Add(branch);
    }

    public int GetDepth(){
        int depth = 1;
        foreach(Branch branch in branches){
            depth = Math.Max(depth, branch.GetDepth() + 1);
        }
        return depth;
    }

    public static void Run(){
        Branch tree = CreateTree1();
        Console.WriteLine($"Depth of Tree 1: {tree.GetDepth()}");
        tree = CreateTree2();
        Console.WriteLine($"Depth of Tree 2: {tree.GetDepth()}");
        tree = CreateTree3();
        Console.WriteLine($"Depth of Tree 3: {tree.GetDepth()}");
        tree = CreateTree4();
        Console.WriteLine($"Depth of Tree 4: {tree.GetDepth()}");
        tree = CreateTree5();
        Console.WriteLine($"Depth of Tree 5: {tree.GetDepth()}");
    }

    public static Branch CreateTree1(){
        return new Branch();
    }
     public static Branch CreateTree2(){
        Branch branch= new Branch();
        branch.AddBranch(new Branch());
        branch.AddBranch(new Branch());
        return branch;
    }
    public static Branch CreateTree3(){
        Branch branch= new Branch();
        branch.AddBranch(CreateTree2());
        branch.AddBranch(new Branch());
        return branch;
    }
    public static Branch CreateTree4(){
        Branch branch= new Branch();
        branch.AddBranch(CreateTree3());
        return branch;
    }
    public static Branch CreateTree5(){
        Branch branch= new Branch();
        branch.AddBranch(CreateTree4());
        branch.AddBranch(CreateTree2());
        return branch;
    }

}