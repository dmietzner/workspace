package com.techelevator;

import static org.junit.Assert.*;

import org.junit.Test;
import org.junit.FixMethodOrder;
import org.junit.runners.MethodSorters;

import com.techelevator.worker.SalariedWorker;

@FixMethodOrder(MethodSorters.NAME_ASCENDING)
public class SalariedWorkerTest {

    @Test
    public void calculateWeeklyPaySalaryBased_RegardlessOfTime() {
        //Arrange
        SalariedWorker sw = new SalariedWorker(52000, "John", "Doe");

        //Assert
        assertEquals(1000, sw.calculateWeeklyPay(0), 0.01);
        assertEquals(1000, sw.calculateWeeklyPay(20), 0.01);
        assertEquals(1000, sw.calculateWeeklyPay(40), 0.01);
        assertEquals(1000, sw.calculateWeeklyPay(60), 0.01);

    }

}
