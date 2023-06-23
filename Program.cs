Console.WriteLine("Choose program 1 or 2:\n[1] Clock angle\n[2] Tree depth");
int program =  Convert.ToInt32(Console.ReadLine());
if(program == 1){
    ClockAngle.Run();
}else if (program == 2){
    Branch.Run();
}