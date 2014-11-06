<?php

class Reservation
{
    private $startDate;
    private $endDate;
    private $guest;


    function __construct($startDate, $endDate, Guest $guest)
    {
        $this->startDate = new DateTime($startDate);
        $this->endDate =  new DateTime($endDate);
        $this->guest = $guest;
    }

    public function setGuest($guest)
    {
        $this->guest = $guest;
    }

    public function getGuest()
    {
        return $this->guest;
    }

    public function setEndDate($endDate)
    {
        $this->endDate = $endDate;
    }

    public function getEndDate()
    {
        return $this->endDate;
    }

    public function setStartDate($startDate)
    {
        $this->startDate = $startDate;
    }

    public function getStartDate()
    {
        return $this->startDate;
    }

    function __toString()
    {
        return "Start Date: " . $this->startDate->format("d-m-y") . "\n"
        . "End Date: " . $this->endDate->format("d-m-y") . "\n"
        . $this->guest->__toString();
    }


} 