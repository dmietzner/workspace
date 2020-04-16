package com.techelevator;

import static org.junit.Assert.*;

import org.junit.Test;
import org.junit.FixMethodOrder;
import org.junit.runners.MethodSorters;

import com.techelevator.deliveryservice.SPUTwoDayGround;

@FixMethodOrder(MethodSorters.NAME_ASCENDING)
public class SPUTwoDayGroundTest {

    @Test
    public void calculateRateTestSPUTwoDayGround() {

        SPUTwoDayGround spu = new SPUTwoDayGround();

        assertEquals(.050, spu.calculateRate(15, 1), 0.1);
        assertEquals(.100, spu.calculateRate(17, 1), 0.1);
    }

}
