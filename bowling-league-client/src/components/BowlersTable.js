// src/components/BowlersTable.js
import React, { useEffect, useState } from 'react';

function BowlersTable() {
  const [bowlers, setBowlers] = useState([]);

  useEffect(() => {
    fetch('http://localhost:5199/Bowlers')
      .then((response) => response.json())
      .then((data) => setBowlers(data))
      .catch((error) => console.error('Error fetching bowlers:', error));
  }, []);

  return (
    <div>
      <h2>Bowlers</h2>
      <table>
      <thead>
        <tr>
            <th>First Name</th>
            <th>Middle Init</th>
            <th>Last Name</th>
            <th>Team Name</th>
            <th>Address</th>
            <th>City</th>
            <th>State</th>
            <th>Zip</th>
            <th>Phone Number</th>
        </tr>
        </thead>
        <tbody>
        {bowlers.map((bowler, index) => (
            <tr key={index}>
            <td>{bowler.firstName}</td>
            <td>{bowler.middleInit}</td>
            <td>{bowler.lastName}</td>
            <td>{bowler.teamName}</td>
            <td>{bowler.address}</td>
            <td>{bowler.city}</td>
            <td>{bowler.state}</td>
            <td>{bowler.zip}</td>
            <td>{bowler.phoneNumber}</td>
            </tr>
        ))}
        </tbody>

      </table>
    </div>
  );
}

export default BowlersTable;
