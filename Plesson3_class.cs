using System;

public class Plesson3_class
{
  private int total_qty = 0;
  private double total_amount = 0;

  // change this if on another system
  public string imagePath = "C:\\Users\\Jude\\Downloads\\MIDTERMS_3RD YEAR_2ND SEM\\images_d\\";
 // string imagePath = "E:\\school\\3rdyr\\2ndsem\\ecp\\midterm\\accumulation\\newnew\\projectNamin\\images\\images-lesson3(POS 2)\\";




  public accumulateTotalQty(int iter){
    this.total_qty += iter;
  }


  public accumulateTotalAmount(double iter){
    this.total_amount += iter;
  }


  public void setPriceAndAddListbox(double price, object namename){

    discountAmountTxtBox.Text = "0.00";
    priceTxtBox.Text = Convert.ToString(price);

    // option 1: check before typecasting
    if(namename is System.Windows.Forms.CheckBox checkBox){
      displayListBox.Items.Add(checkBox.Text + " " + priceTxtBox.Text);
    }

    // option 2: direct casting assuming that namename is always a checkbox
    //displayListBox.Items.Add((System.Windows.Forms.CheckBox)namename.Text);

    quantityTxtBox.Text = "0";
    quantityTxtBox.Focus();
  }


}

