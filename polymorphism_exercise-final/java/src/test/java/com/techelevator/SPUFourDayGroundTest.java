package com.techelevator;

import static org.junit.Assert.*;

import org.junit.Test;
import org.junit.FixMethodOrder;
import org.junit.runners.MethodSorters;

import com.techelevator.deliveryservice.SPUFourDayGround;

@FixMethodOrder(MethodSorters.NAME_ASCENDING)
public class SPUFourDayGroundTest {

    @Test
    public void calculateRateTestSPUFourDayGround() {

        SPUFourDayGround spu = new SPUFourDayGround();

        assertEquals(.0050, spu.calculateRate(15, 1), 0.01);
        assertEquals(.0100, spu.calculateRate(17, 1), 0.01);
    }

}
