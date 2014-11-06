<?php

class SingleRoom extends Room {
    const SINGLE_ROOM_BEDS = 1;

    function __construct($roomNumber, $price)
    {
        parent::__construct($roomNumber, 'SINGLE_ROOM_BEDS', $price, true, false, RoomType::STANDARD);
        $this->addExtras(Extra::TV);
        $this->addExtras(Extra::AIR_CONDITIONER);
    }
}