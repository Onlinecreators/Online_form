public class Calculate {
  public ActionResult Index(){
    return View();
  }
  public ActionResult Calculate(int num1, int num2){
    this.ViewBag.num1 = num1;
    this.ViewBag.num2 = num2;
    this.ViewBag.sum = num1 + num2;
    return View("Index");
  }
}
