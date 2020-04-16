package com.techelevator;

import static org.junit.Assert.*;

import org.junit.Test;
import org.junit.FixMethodOrder;
import org.junit.runners.MethodSorters;

import com.techelevator.worker.VolunteerWorker;

@FixMethodOrder(MethodSorters.NAME_ASCENDING)
public class VolunteerWorkerTest {

    @Test
    public void calculateWeeklyPayAlwaysExpectZero() {

        VolunteerWorker vw = new VolunteerWorker("John", "Doe");

        assertEquals(0, vw.calculateWeeklyPay(0), 0.01);
        assertEquals(0, vw.calculateWeeklyPay(20), 0.01);
        assertEquals(0, vw.calculateWeeklyPay(40), 0.01);
    }

}
