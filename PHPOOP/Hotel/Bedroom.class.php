<?php
class Bedroom extends Room {
    const BEDROOM_BEDS = 2;

    function __construct($roomNumber, $price)
    {
        parent::__construct($roomNumber, 'BEDROOM_BEDS', $price, true, true, RoomType::GOLD);
        $this->addExtras(Extra::TV);
        $this->addExtras(Extra::AIR_CONDITIONER);
        $this->addExtras(Extra::REFRIGERATOR);
        $this->addExtras(Extra::MINI_BAR);
        $this->addExtras(Extra::BATHTUB);
    }
} 