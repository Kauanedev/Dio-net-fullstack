import styled from "styled-components";

export const ButtonContainer = styled.button.attrs((props) => ({
  type: "button",
}))<React.ButtonHTMLAttributes<HTMLButtonElement>>`
  width: 100%;
  height: 42px;
  background-color: #81259d;
  color: #fff;
  border: 1px solid #81259d;
  border-radius: 21px;

  &:hover {
    opacity: 0.6;
    cursor: pointer;
  }

  &:disabled {
    background-color: #ccc;
    border: 1px solid #ccc;
    cursor: not-allowed;
  }
`;
