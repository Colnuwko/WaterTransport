import { useState } from "react";

import Accordion from "react-bootstrap/Accordion";

import styles from "./UserSettingsMenu.module.css";

export default function UserSettingsMenu({ items }) {
  const [active, setActive] = useState("");
  
  return (
    <div className={styles["user-settings"]}>

      <Accordion
        activeKey={active}
        onSelect={(key) => setActive(key)}
        className={styles["menu"]}
      >
      {items.map((item) => (
        <Accordion.Item 
          eventKey={item.key} 
          key={item.key} 
          className={styles["menu-item"]}
        >
          <Accordion.Header className={styles["menu-item-title"]}>
            {item.label}
          </Accordion.Header>
          <Accordion.Body className={styles["menu-item-body"]}>
            {item.content}
          </Accordion.Body>
        </Accordion.Item>
        ))}
      </Accordion>
      
    </div>
  );
}