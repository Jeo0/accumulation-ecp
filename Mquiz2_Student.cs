using System;
using System.Security.Cryptography.X509Certificates;

public class Mquiz2_Student
{
    public double total_tuition_fee,
        total_msc_fee,
        lab_fee,
        sap_fee,
        cisco_fee,
        exam_booklet_fee,
        total_other_school_fees,
        total_tuition_and_fees,
        installment_charge = 1200, // this is constant
        downpayment,
        first_installment,
        second_installment,
        third_installment,
        amount_due,
        grand_total;

    public string student_name,
                    program,
                    date_enrolled,
                    mode,
                    student_number,
                    year_level,
                    scholar;

    public Mquiz2_Student()
    {
    }
}
