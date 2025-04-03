using System;

public class Plesson3_class
{
  private int total_qty = 0;
  private double total_amount = 0;

  // change this if on another system
  public string imagePath = "C:\\Users\\Jude\\Downloads\\MIDTERMS_3RD YEAR_2ND SEM\\images_d\\";
 // string imagePath = "E:\\school\\3rdyr\\2ndsem\\ecp\\midterm\\accumulation\\newnew\\projectNamin\\images\\images-lesson3(POS 2)\\";




  public void accumulateTotalQty(int iter){
    this.total_qty += iter;
  }


  public void accumulateTotalAmount(double iter){
    this.total_amount += iter;
  }

    public int getTotalQty() {
        return this.total_qty;
    }

    public int getTotalAmount() {
        return (int)this.total_amount;
    }




}

