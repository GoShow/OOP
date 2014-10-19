<?php

class Apartment extends Room {
    const APARTMENT_BEDS = 4;

    function __construct($roomNumber, $price)
    {
        parent::__construct($roomNumber, 'APARTMENT_BEDS', $price, true, true, RoomType::DIAMOND);
        $this->addExtras(Extra::TV);
        $this->addExtras(Extra::AIR_CONDITIONER);
        $this->addExtras(Extra::REFRIGERATOR);
        $this->addExtras(Extra::MINI_BAR);
        $this->addExtras(Extra::BATHTUB);
        $this->addExtras(Extra::FREE_WI_FI);
        $this->addExtras(Extra::KITCHEN_BOX);
    }
} 